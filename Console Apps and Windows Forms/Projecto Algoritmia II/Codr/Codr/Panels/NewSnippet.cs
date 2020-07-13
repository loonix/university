using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Codr.Core.Classes;
using Codr.Core.CodeEditor;
using ScintillaNET;

namespace CodrApp
{
    public partial class Snippets : Form
    {

        public Snippets()
        {
            InitializeComponent();
        }

        #region FormLoad

        ScintillaNET.Scintilla TextArea;
        private void Main_Load(object sender, EventArgs e)
        {
            // CREATE CONTROL
            TextArea = new ScintillaNET.Scintilla();
            TextPanel.Controls.Add(TextArea);

            // BASIC CONFIG
            TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += this.OnTextChanged;

            // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            // STYLING
            InitColors();
            InitSyntaxColoring();

            // NUMBER MARGIN
            InitNumberMargin();

            // BOOKMARK MARGIN
            InitBookmarkMargin();

            // CODE FOLDING MARGIN
            InitCodeFolding();

            // DRAG DROP
            InitDragDropFile();

            // INIT HOTKEYS
            InitHotkeys();


            loadAllExtensions();
            loadAllSnippets();
            ClearFields();
            textBoxId.Visible = false;
        }

        /// <summary>
        /// Loads all extensions into the comboBox
        /// </summary>
        void loadAllExtensions()
        {
            string comandoSQL = "SELECT * from extensions";
            DataTable table = ClassBD.GetData(comandoSQL); // recebe os dados
            comboboxExtensions.ValueMember = "id";
            comboboxExtensions.DisplayMember = "name";
            comboboxExtensions.DataSource = table;
            comboboxExtensions.SelectedItem = null;
        }

        /// <summary>
        /// Loads all snippets into the comboBox
        /// </summary>
        void loadAllSnippets()
        {
            string comandoSQL = "SELECT * from snippets";
            DataTable table = ClassBD.GetData(comandoSQL); // recebe os dados

            listOfSnippets.ValueMember = "id";
            listOfSnippets.DisplayMember = "title";
            listOfSnippets.DataSource = table;
            listOfSnippets.SelectedItem = null;
        }

        #endregion

        private void listOfSnippets_SelectedIndexChanged(object sender, EventArgs e)
        {
            object id = listOfSnippets.SelectedValue;
            if (id != null)
            {
                var snippet = ClassSnippets.OpenSnippet(id.ToString());
                textBoxId.Text = snippet.id;
                textBoxTitulo.Text = snippet.title;
                textBoxDescricao.Text = snippet.description;
                comboboxExtensions.SelectedItem = snippet.id_extension;
                comboboxExtensions.Text = ClassExtensions.GetExtensionName(snippet.id_extension);
                LoadDataFromFile(ClassFile.filesFolder + snippet.path, true);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxTitulo.Text == "" || textBoxDescricao.Text == "" || TextArea.Text == "" || comboboxExtensions.Text == "")
                {
                    MessageBox.Show("All Fields are required", "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string idExt = ClassExtensions.AddExtension(comboboxExtensions.Text);

                if (idExt != "")
                {
                    string filePath;
                    if (listOfSnippets.SelectedIndex == -1)
                    {
                        filePath = ClassSnippets.AddSnippet(textBoxTitulo.Text, textBoxDescricao.Text, idExt);
                    }
                    else
                    {
                        filePath = ClassSnippets.EditSnippet(int.Parse(textBoxId.Text), textBoxTitulo.Text, textBoxDescricao.Text, idExt);
                    }
                    filePath = ClassFile.filesFolder + filePath;
                    if (filePath != "")
                    {
                        if(!Directory.Exists(ClassFile.filesFolder + comboboxExtensions.Text))
                        {
                            Directory.CreateDirectory(ClassFile.filesFolder + comboboxExtensions.Text);
                        }
                        File.WriteAllText(filePath, "");
                        using (StreamWriter strwriter = System.IO.File.AppendText(filePath))
                        {
                            strwriter.Write(this.TextArea.Text);
                        }
                        loadAllExtensions();
                        loadAllSnippets();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Unable to create the snippet, \n" + err,
                     "CODr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxTitulo.Text = "Title";
            textBoxDescricao.Text = "Description";
            TextArea.Text = "";

            comboboxExtensions.SelectedIndex = -1;
            listOfSnippets.SelectedIndex = -1;
        }

        #region Numbers, Bookmarks, Code Folding

        /// <summary>
        /// the background color of the text area
        /// </summary>
        private const int BACK_COLOR = 0x383838;

        /// <summary>
        /// default text color of the text area
        /// </summary>
        private const int FORE_COLOR = 0xc1c1c1;

        /// <summary>
        /// change this to whatever margin you want the line numbers to show in
        /// </summary>
        private const int NUMBER_MARGIN = 1;

        /// <summary>
        /// change this to whatever margin you want the bookmarks/breakpoints to show in
        /// </summary>
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;

        /// <summary>
        /// change this to whatever margin you want the code folding tree (+/-) to show in
        /// </summary>
        private const int FOLDING_MARGIN = 3;

        /// <summary>
        /// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
        /// </summary>
        private const bool CODEFOLDING_CIRCULAR = false;

        private void InitNumberMargin()
        {

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            TextArea.MarginClick += TextArea_MarginClick;
        }

        private void InitBookmarkMargin()
        {

            //TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

            var margin = TextArea.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);
            //margin.Cursor = MarginCursor.Arrow;

            var marker = TextArea.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0x000000));
            marker.SetAlpha(100);

        }

        private void InitCodeFolding()
        {

            TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
            TextArea.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

            // Enable code folding
            TextArea.SetProperty("fold", "1");
            TextArea.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            TextArea.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            TextArea.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            TextArea.Margins[FOLDING_MARGIN].Sensitive = true;
            TextArea.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                TextArea.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
                TextArea.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            TextArea.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            TextArea.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            TextArea.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            TextArea.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            TextArea.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            TextArea.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            TextArea.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            TextArea.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }

        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        #endregion

        #region HotKeys
        private void OnTextChanged(object sender, EventArgs e)
        {

        }


        private void InitColors()
        {
            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
        }
        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        public void InvokeIfNeeded(Action action)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action.Invoke();
            }
        }
        private void ZoomIn()
        {
            TextArea.ZoomIn();
        }

        private void ZoomOut()
        {
            TextArea.ZoomOut();
        }

        private void InitHotkeys()
        {
            // register the hotkeys with the form
            CodeEditorHotKeys.AddHotKey(this, OpenSearch, Keys.F, true);
            CodeEditorHotKeys.AddHotKey(this, ZoomIn, Keys.Oemplus, true);
            CodeEditorHotKeys.AddHotKey(this, ZoomOut, Keys.OemMinus, true);
            CodeEditorHotKeys.AddHotKey(this, CloseSearch, Keys.Escape);
            // allows user to use ctrl + f to search
            TextArea.ClearCmdKey(Keys.Control | Keys.F);
        }


        private void InitSyntaxColoring()
        {
            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Segoe UI";
            TextArea.Styles[Style.Default].Size = 12;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x3C3C3C);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
        }
        #endregion

        #region Quick Search Bar

        bool SearchIsOpen = false;

        private void OpenSearch()
        {

            CodeEditorSearchManager.SearchBox = TxtSearch;
            CodeEditorSearchManager.TextArea = TextArea;

            if (!SearchIsOpen)
            {
                SearchIsOpen = true;
                InvokeIfNeeded(delegate ()
                {
                    PanelSearch.Visible = true;
                    TxtSearch.Text = CodeEditorSearchManager.LastSearch;
                    TxtSearch.Focus();
                    TxtSearch.SelectAll();
                });
            }
            else
            {
                InvokeIfNeeded(delegate ()
                {
                    TxtSearch.Focus();
                    TxtSearch.SelectAll();
                });
            }
        }
        private void CloseSearch()
        {
            if (SearchIsOpen)
            {
                SearchIsOpen = false;
                InvokeIfNeeded(delegate ()
                {
                    PanelSearch.Visible = false;
                    //CurBrowser.GetBrowser().StopFinding(true);
                });
            }
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            CloseSearch();
        }

        private void BtnPrevSearch_Click(object sender, EventArgs e)
        {
            CodeEditorSearchManager.Find(false, false);
        }
        private void BtnNextSearch_Click(object sender, EventArgs e)
        {
            CodeEditorSearchManager.Find(true, false);
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            CodeEditorSearchManager.Find(true, true);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (CodeEditorHotKeys.IsHotkey(e, Keys.Enter))
            {
                CodeEditorSearchManager.Find(true, false);
            }
            if (CodeEditorHotKeys.IsHotkey(e, Keys.Enter, true) || CodeEditorHotKeys.IsHotkey(e, Keys.Enter, false, true))
            {
                CodeEditorSearchManager.Find(false, false);
            }
        }

        #endregion

        #region Drag & Drop File

        public void InitDragDropFile()
        {

            TextArea.AllowDrop = true;
            TextArea.DragEnter += delegate (object sender, DragEventArgs e)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            };
            TextArea.DragDrop += delegate (object sender, DragEventArgs e)
            {

                // get file drop
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {

                    Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                    if (a != null)
                    {

                        string path = a.GetValue(0).ToString();

                        LoadDataFromFile(path);

                    }
                }
            };

        }

        private void LoadDataFromFile(string path, bool hasTitle = false)
        {
            if (File.Exists(path))
            {
                if (!hasTitle)
                {
                    textBoxTitulo.Text = Path.GetFileName(path);
                }
                TextArea.Text = File.ReadAllText(path);

            }
        }



        #endregion


    }
}
