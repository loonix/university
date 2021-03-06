﻿using Codr.Core.Classes;
using CodrApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Codr.Forms
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
            createFolders();
        }

        /// <summary>
        /// Creates all folders in Bin/Debug/Core/Files
        /// </summary>
        private void createFolders()
        {
            SqlConnection sqlConnection = ClassBD.OpenDatabase();

            //2. Criar comando SQL SELECT para submeter à BD
            string SQL;
            SQL = "SELECT name FROM extensions";

            SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<string> folderNames = new List<string>();

            while (sqlDataReader.Read())
            {
                folderNames.Add(sqlDataReader["name"].ToString());
            }

            foreach (var folder in folderNames)
            {
                var path = ClassFile.filesFolder + folder;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }

        private void buttonTarefas_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonNotas.Height;
            panelActivo.Top = buttonNotas.Top;
            buttonNotas.BackColor = Color.MediumSlateBlue;
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

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelActivo.Height = buttonSobre.Height;
            panelActivo.Top = buttonSobre.Top;
            buttonNotas.BackColor = Color.FromArgb(51, 51, 51);
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
            buttonNovaTarefa.BackColor = Color.FromArgb(51, 51, 51);
            buttonSobre.BackColor = Color.FromArgb(51, 51, 51);
            buttonCategorias.BackColor = Color.MediumSlateBlue;

            Extensions objForm = new Extensions();
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
            Application.Exit();
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
