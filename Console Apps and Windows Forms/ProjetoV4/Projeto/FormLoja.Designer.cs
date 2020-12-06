namespace ExemploProjeto
{
    partial class FormLoja
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
            this.listaButton = new System.Windows.Forms.Button();
            this.dataInicioAtividadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataInicioAtividadeLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.codigoLojaTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.codigoLojaLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.lojaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.lojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.moradaLabel = new System.Windows.Forms.Label();
            this.diaSemanaUserControl1 = new ExemploProjeto.DiaSemanaUserControl();
            this.lojaMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(251, 34);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(38, 20);
            this.listaButton.TabIndex = 19;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // dataInicioAtividadeDateTimePicker
            // 
            this.dataInicioAtividadeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicioAtividadeDateTimePicker.Location = new System.Drawing.Point(144, 139);
            this.dataInicioAtividadeDateTimePicker.Name = "dataInicioAtividadeDateTimePicker";
            this.dataInicioAtividadeDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dataInicioAtividadeDateTimePicker.TabIndex = 18;
            // 
            // dataInicioAtividadeLabel
            // 
            this.dataInicioAtividadeLabel.AutoSize = true;
            this.dataInicioAtividadeLabel.Location = new System.Drawing.Point(12, 139);
            this.dataInicioAtividadeLabel.Name = "dataInicioAtividadeLabel";
            this.dataInicioAtividadeLabel.Size = new System.Drawing.Size(123, 13);
            this.dataInicioAtividadeLabel.TabIndex = 17;
            this.dataInicioAtividadeLabel.Text = "Data início de atividade:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(144, 113);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(102, 20);
            this.areaTextBox.TabIndex = 16;
            // 
            // codigoLojaTextBox
            // 
            this.codigoLojaTextBox.Location = new System.Drawing.Point(144, 34);
            this.codigoLojaTextBox.Name = "codigoLojaTextBox";
            this.codigoLojaTextBox.Size = new System.Drawing.Size(99, 20);
            this.codigoLojaTextBox.TabIndex = 15;
            this.codigoLojaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigoLojaTextBox_KeyUp);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(15, 116);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(32, 13);
            this.areaLabel.TabIndex = 14;
            this.areaLabel.Text = "Area:";
            // 
            // codigoLojaLabel
            // 
            this.codigoLojaLabel.AutoSize = true;
            this.codigoLojaLabel.Location = new System.Drawing.Point(16, 37);
            this.codigoLojaLabel.Name = "codigoLojaLabel";
            this.codigoLojaLabel.Size = new System.Drawing.Size(78, 13);
            this.codigoLojaLabel.TabIndex = 13;
            this.codigoLojaLabel.Text = "Codigo da Loja";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(144, 60);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(302, 20);
            this.descricaoTextBox.TabIndex = 21;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(15, 63);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(58, 13);
            this.descricaoLabel.TabIndex = 20;
            this.descricaoLabel.Text = "Descrição:";
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(479, 119);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 25;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sair_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(479, 34);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 24;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novo_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(479, 90);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 23;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(480, 63);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 22;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravar_Click);
            // 
            // lojaMenuStrip
            // 
            this.lojaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojaToolStripMenuItem});
            this.lojaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.lojaMenuStrip.Name = "lojaMenuStrip";
            this.lojaMenuStrip.Size = new System.Drawing.Size(566, 24);
            this.lojaMenuStrip.TabIndex = 26;
            this.lojaMenuStrip.Text = "menuStrip1";
            // 
            // lojaToolStripMenuItem
            // 
            this.lojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            this.lojaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lojaToolStripMenuItem.Text = "Loja";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novo_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gravarToolStripMenuItem.Text = "Gravar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.gravar_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sair_Click);
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.Location = new System.Drawing.Point(144, 87);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(303, 20);
            this.moradaTextBox.TabIndex = 28;
            // 
            // moradaLabel
            // 
            this.moradaLabel.AutoSize = true;
            this.moradaLabel.Location = new System.Drawing.Point(14, 90);
            this.moradaLabel.Name = "moradaLabel";
            this.moradaLabel.Size = new System.Drawing.Size(46, 13);
            this.moradaLabel.TabIndex = 27;
            this.moradaLabel.Text = "Morada;";
            // 
            // diaSemanaUserControl1
            // 
            this.diaSemanaUserControl1.Location = new System.Drawing.Point(251, 136);
            this.diaSemanaUserControl1.Name = "diaSemanaUserControl1";
            this.diaSemanaUserControl1.Size = new System.Drawing.Size(196, 21);
            this.diaSemanaUserControl1.TabIndex = 29;
            this.diaSemanaUserControl1.TipoDiaSemana = ExemploProjeto.EnumTipoDiaSemana.DayNames;
            // 
            // FormLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 177);
            this.Controls.Add(this.diaSemanaUserControl1);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(this.moradaLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.dataInicioAtividadeDateTimePicker);
            this.Controls.Add(this.dataInicioAtividadeLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.codigoLojaTextBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.codigoLojaLabel);
            this.Controls.Add(this.lojaMenuStrip);
            this.MainMenuStrip = this.lojaMenuStrip;
            this.Name = "FormLoja";
            this.Text = "Form Loja";
            this.lojaMenuStrip.ResumeLayout(false);
            this.lojaMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.DateTimePicker dataInicioAtividadeDateTimePicker;
        private System.Windows.Forms.Label dataInicioAtividadeLabel;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox codigoLojaTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label codigoLojaLabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.MenuStrip lojaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.Label moradaLabel;
        private DiaSemanaUserControl diaSemanaUserControl1;
    }
}