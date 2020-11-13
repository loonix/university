﻿namespace ExemploProjeto
{
    partial class ProjetoForm
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
            this.gravarButton = new System.Windows.Forms.Button();
            this.idProjetolabel = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.idProjetoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.errorProviderProjeto = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataInicioLabel = new System.Windows.Forms.Label();
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFimLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.listaButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjeto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(462, 64);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 0;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravar_Click);
            // 
            // idProjetolabel
            // 
            this.idProjetolabel.AutoSize = true;
            this.idProjetolabel.Location = new System.Drawing.Point(30, 30);
            this.idProjetolabel.Name = "idProjetolabel";
            this.idProjetolabel.Size = new System.Drawing.Size(54, 13);
            this.idProjetolabel.TabIndex = 1;
            this.idProjetolabel.Text = "ID Projeto";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(29, 60);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(58, 13);
            this.descricaoLabel.TabIndex = 2;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // idProjetoTextBox
            // 
            this.idProjetoTextBox.Location = new System.Drawing.Point(98, 27);
            this.idProjetoTextBox.Name = "idProjetoTextBox";
            this.idProjetoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idProjetoTextBox.TabIndex = 3;
            this.idProjetoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idProjetoTextBox_KeyUp);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(97, 57);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(292, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(461, 91);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 5;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // errorProviderProjeto
            // 
            this.errorProviderProjeto.ContainerControl = this;
            // 
            // dataInicioLabel
            // 
            this.dataInicioLabel.AutoSize = true;
            this.dataInicioLabel.Location = new System.Drawing.Point(29, 101);
            this.dataInicioLabel.Name = "dataInicioLabel";
            this.dataInicioLabel.Size = new System.Drawing.Size(62, 13);
            this.dataInicioLabel.TabIndex = 6;
            this.dataInicioLabel.Text = "Data início:";
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(98, 101);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dataInicioDateTimePicker.TabIndex = 7;
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(98, 137);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dataFimDateTimePicker.TabIndex = 9;
            // 
            // dataFimLabel
            // 
            this.dataFimLabel.AutoSize = true;
            this.dataFimLabel.Location = new System.Drawing.Point(29, 137);
            this.dataFimLabel.Name = "dataFimLabel";
            this.dataFimLabel.Size = new System.Drawing.Size(49, 13);
            this.dataFimLabel.TabIndex = 8;
            this.dataFimLabel.Text = "Data fim:";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(29, 181);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(34, 13);
            this.valorLabel.TabIndex = 10;
            this.valorLabel.Text = "Valor:";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(97, 178);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 11;
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(204, 27);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(38, 20);
            this.listaButton.TabIndex = 12;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.projetoToolStripMenuItem.Text = "Projeto";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novo_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gravarToolStripMenuItem.Text = "Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravar_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sair_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(461, 35);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 14;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novo_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(461, 120);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 15;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sair_Click);
            // 
            // ProjetoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.dataFimDateTimePicker);
            this.Controls.Add(this.dataFimLabel);
            this.Controls.Add(this.dataInicioDateTimePicker);
            this.Controls.Add(this.dataInicioLabel);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.idProjetoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.idProjetolabel);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjetoForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjeto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Label idProjetolabel;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.TextBox idProjetoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.ErrorProvider errorProviderProjeto;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private System.Windows.Forms.Label dataFimLabel;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.Label dataInicioLabel;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

