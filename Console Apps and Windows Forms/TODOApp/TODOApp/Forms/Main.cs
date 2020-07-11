using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Codr;

namespace CodrApp


{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            buttonNotas.PerformClick();
        }

        private void buttonTarefas_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonNotas.Height;
            panelActivo.Top = buttonNotas.Top;
            buttonNotas.BackColor = Color.MediumSlateBlue;
            buttonExportar.BackColor = Color.FromArgb(51, 51, 51);
            buttonNovaTarefa.BackColor = Color.FromArgb(51, 51, 51);
            buttonSobre.BackColor = Color.FromArgb(51, 51, 51);
            buttonCategorias.BackColor = Color.FromArgb(51, 51, 51);

            AllSnippets objForm = new AllSnippets();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            panelMain.Controls.Add(objForm);
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonExportar.Height;
            panelActivo.Top = buttonExportar.Top;
            buttonNotas.BackColor = Color.FromArgb(51, 51, 51);
            buttonExportar.BackColor = Color.MediumSlateBlue;
            buttonNovaTarefa.BackColor = Color.FromArgb(51, 51, 51);
            buttonSobre.BackColor = Color.FromArgb(51, 51, 51);
            buttonCategorias.BackColor = Color.FromArgb(51, 51, 51);

        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonSobre.Height;
            panelActivo.Top = buttonSobre.Top;
            buttonNotas.BackColor = Color.FromArgb(51, 51, 51);
            buttonExportar.BackColor = Color.FromArgb(51, 51, 51);
            buttonNovaTarefa.BackColor = Color.FromArgb(51, 51, 51);
            buttonSobre.BackColor = Color.MediumSlateBlue;
            buttonCategorias.BackColor = Color.FromArgb(51, 51, 51);

            Sobre objForm = new Sobre();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            panelMain.Controls.Add(objForm);
        }

        private void buttonNovaTarefa_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonNovaTarefa.Height;
            panelActivo.Top = buttonNovaTarefa.Top;
            buttonNotas.BackColor = Color.FromArgb(51, 51, 51);
            buttonExportar.BackColor = Color.FromArgb(51, 51, 51);
            buttonNovaTarefa.BackColor = Color.MediumSlateBlue;
            buttonSobre.BackColor = Color.FromArgb(51, 51, 51);
            buttonCategorias.BackColor = Color.FromArgb(51, 51, 51);

            Snippets objForm = new Snippets();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            panelMain.Controls.Add(objForm);
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonCategorias.Height;
            panelActivo.Top = buttonCategorias.Top;
            buttonNotas.BackColor = Color.FromArgb(51, 51, 51);
            buttonExportar.BackColor = Color.FromArgb(51, 51, 51);
            buttonNovaTarefa.BackColor = Color.FromArgb(51, 51, 51);
            buttonSobre.BackColor = Color.FromArgb(51, 51, 51);
            buttonCategorias.BackColor = Color.MediumSlateBlue;

            Categories objForm = new Categories();
            objForm.TopLevel = false;
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
            panelMain.Controls.Add(objForm);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            formMove(e);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            formMove(e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            formMove(e);
        }

        private void formMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            MaxMinJanela();
        }

        private void MaxMinJanela()
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            buttonMaximizar.Text = this.WindowState == FormWindowState.Maximized ? "🗗" : "🗖";
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            MaxMinJanela();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
