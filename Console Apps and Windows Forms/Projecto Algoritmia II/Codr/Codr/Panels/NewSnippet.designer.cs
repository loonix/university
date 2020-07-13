namespace CodrApp
{
    partial class Snippets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboboxExtensions = new System.Windows.Forms.ComboBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listOfSnippets = new System.Windows.Forms.ListBox();
            this.snippetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_AllSnippets = new Codr.Core.DB.DB_AllSnippets();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.snippetsTableAdapter = new Codr.Core.DB.DB_AllSnippetsTableAdapters.snippetsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snippetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AllSnippets)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.15311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.17887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.15311F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.51491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboboxExtensions, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 54);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // comboboxExtensions
            // 
            this.comboboxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboboxExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxExtensions.ForeColor = System.Drawing.Color.White;
            this.comboboxExtensions.FormattingEnabled = true;
            this.comboboxExtensions.Location = new System.Drawing.Point(324, 13);
            this.comboboxExtensions.Name = "comboboxExtensions";
            this.comboboxExtensions.Size = new System.Drawing.Size(186, 28);
            this.comboboxExtensions.TabIndex = 12;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.ForeColor = System.Drawing.Color.White;
            this.textBoxTitulo.Location = new System.Drawing.Point(14, 13);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(293, 27);
            this.textBoxTitulo.TabIndex = 0;
            this.textBoxTitulo.Text = "Titulo";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(516, 3);
            this.buttonSave.MaximumSize = new System.Drawing.Size(150, 150);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 48);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(3, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(5, 20);
            this.textBoxId.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.205175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.59434F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.200489F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxDescricao, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 52);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescricao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricao.ForeColor = System.Drawing.Color.White;
            this.textBoxDescricao.Location = new System.Drawing.Point(18, 12);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(651, 27);
            this.textBoxDescricao.TabIndex = 5;
            this.textBoxDescricao.Text = "Descrição";
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.PanelSearch);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(3, 122);
            this.TextPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(688, 429);
            this.TextPanel.TabIndex = 4;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(359, 0);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(329, 40);
            this.PanelSearch.TabIndex = 11;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatAppearance.BorderSize = 0;
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Location = new System.Drawing.Point(270, 2);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.Text = "⯆";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            this.BtnNextSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatAppearance.BorderSize = 0;
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPrevSearch.Location = new System.Drawing.Point(242, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.Text = "⯅";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatAppearance.BorderSize = 0;
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Location = new System.Drawing.Point(298, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.Text = "×";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.White;
            this.TxtSearch.Location = new System.Drawing.Point(10, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(226, 25);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 555);
            this.panel2.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(908, 555);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.listOfSnippets, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonNew, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.598596F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.80576F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.595639F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(210, 555);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // listOfSnippets
            // 
            this.listOfSnippets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.listOfSnippets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfSnippets.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.snippetsBindingSource, "id", true));
            this.listOfSnippets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfSnippets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfSnippets.ForeColor = System.Drawing.Color.White;
            this.listOfSnippets.FormattingEnabled = true;
            this.listOfSnippets.ItemHeight = 20;
            this.listOfSnippets.Location = new System.Drawing.Point(3, 45);
            this.listOfSnippets.Name = "listOfSnippets";
            this.listOfSnippets.Size = new System.Drawing.Size(204, 464);
            this.listOfSnippets.TabIndex = 0;
            this.listOfSnippets.SelectedIndexChanged += new System.EventHandler(this.listOfSnippets_SelectedIndexChanged);
            // 
            // snippetsBindingSource
            // 
            this.snippetsBindingSource.DataMember = "snippets";
            this.snippetsBindingSource.DataSource = this.dB_AllSnippets;
            // 
            // dB_AllSnippets
            // 
            this.dB_AllSnippets.DataSetName = "DB_AllSnippets";
            this.dB_AllSnippets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Snippets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Location = new System.Drawing.Point(3, 515);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(204, 37);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "NEW";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TextPanel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98901F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.49294F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(694, 555);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // snippetsTableAdapter
            // 
            this.snippetsTableAdapter.ClearBeforeFill = true;
            // 
            // Snippets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Snippets";
            this.Text = "Novo Snippet";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TextPanel.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snippetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AllSnippets)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Button BtnPrevSearch;
        private System.Windows.Forms.Button BtnCloseSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listOfSnippets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Codr.Core.DB.DB_AllSnippets dB_AllSnippets;
        private System.Windows.Forms.BindingSource snippetsBindingSource;
        private Codr.Core.DB.DB_AllSnippetsTableAdapters.snippetsTableAdapter snippetsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxExtensions;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxId;
    }
}