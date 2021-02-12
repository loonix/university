namespace Exame2019
{
    partial class FormTesteCovid19
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
            this.codigoTesteCovid19TextBox = new System.Windows.Forms.TextBox();
            this.testeCovid19ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.obterListaButton = new System.Windows.Forms.Button();
            this.testeCovid19ListBox = new System.Windows.Forms.ListBox();
            this.dataTesteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.codigoTesteCovid19Label = new System.Windows.Forms.Label();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.dataTesteLabel = new System.Windows.Forms.Label();
            this.componenteMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoTesteLabel = new System.Windows.Forms.Label();
            this.novoButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.resultadoPanel = new System.Windows.Forms.Panel();
            this.positivoRadioButton = new System.Windows.Forms.RadioButton();
            this.negativoRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.testeCovid19ErrorProvider)).BeginInit();
            this.componenteMenuStrip.SuspendLayout();
            this.resultadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoTesteCovid19TextBox
            // 
            this.codigoTesteCovid19TextBox.Location = new System.Drawing.Point(111, 38);
            this.codigoTesteCovid19TextBox.Name = "codigoTesteCovid19TextBox";
            this.codigoTesteCovid19TextBox.Size = new System.Drawing.Size(82, 20);
            this.codigoTesteCovid19TextBox.TabIndex = 0;
            this.codigoTesteCovid19TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigoTesteCovid19TextBox_KeyUp);
            // 
            // testeCovid19ErrorProvider
            // 
            this.testeCovid19ErrorProvider.ContainerControl = this;
            // 
            // obterListaButton
            // 
            this.obterListaButton.Location = new System.Drawing.Point(15, 215);
            this.obterListaButton.Name = "obterListaButton";
            this.obterListaButton.Size = new System.Drawing.Size(75, 23);
            this.obterListaButton.TabIndex = 4;
            this.obterListaButton.Text = "Obter lista";
            this.obterListaButton.UseVisualStyleBackColor = true;
            // 
            // testeCovid19ListBox
            // 
            this.testeCovid19ListBox.FormattingEnabled = true;
            this.testeCovid19ListBox.Location = new System.Drawing.Point(15, 244);
            this.testeCovid19ListBox.Name = "testeCovid19ListBox";
            this.testeCovid19ListBox.Size = new System.Drawing.Size(370, 69);
            this.testeCovid19ListBox.TabIndex = 5;
            // 
            // dataTesteDateTimePicker
            // 
            this.dataTesteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTesteDateTimePicker.Location = new System.Drawing.Point(111, 91);
            this.dataTesteDateTimePicker.Name = "dataTesteDateTimePicker";
            this.dataTesteDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dataTesteDateTimePicker.TabIndex = 6;
            this.dataTesteDateTimePicker.Value = new System.DateTime(2018, 11, 23, 0, 0, 0, 0);
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.Location = new System.Drawing.Point(111, 117);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(47, 20);
            this.idadeTextBox.TabIndex = 7;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(15, 319);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultadoLabel.Location = new System.Drawing.Point(97, 320);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(98, 23);
            this.resultadoLabel.TabIndex = 9;
            // 
            // codigoTesteCovid19Label
            // 
            this.codigoTesteCovid19Label.AutoSize = true;
            this.codigoTesteCovid19Label.Location = new System.Drawing.Point(12, 45);
            this.codigoTesteCovid19Label.Name = "codigoTesteCovid19Label";
            this.codigoTesteCovid19Label.Size = new System.Drawing.Size(43, 13);
            this.codigoTesteCovid19Label.TabIndex = 15;
            this.codigoTesteCovid19Label.Text = "Codigo:";
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Location = new System.Drawing.Point(11, 123);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(37, 13);
            this.idadeLabel.TabIndex = 17;
            this.idadeLabel.Text = "Idade:";
            // 
            // dataTesteLabel
            // 
            this.dataTesteLabel.AutoSize = true;
            this.dataTesteLabel.Location = new System.Drawing.Point(11, 98);
            this.dataTesteLabel.Name = "dataTesteLabel";
            this.dataTesteLabel.Size = new System.Drawing.Size(59, 13);
            this.dataTesteLabel.TabIndex = 18;
            this.dataTesteLabel.Text = "Data teste:";
            // 
            // componenteMenuStrip
            // 
            this.componenteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefaToolStripMenuItem});
            this.componenteMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.componenteMenuStrip.Name = "componenteMenuStrip";
            this.componenteMenuStrip.Size = new System.Drawing.Size(421, 24);
            this.componenteMenuStrip.TabIndex = 10;
            this.componenteMenuStrip.Text = "menuStrip1";
            // 
            // tarefaToolStripMenuItem
            // 
            this.tarefaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            this.tarefaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.tarefaToolStripMenuItem.Text = "Teste";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gravarToolStripMenuItem.Text = "Gravar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
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
            // 
            // resultadoTesteLabel
            // 
            this.resultadoTesteLabel.AutoSize = true;
            this.resultadoTesteLabel.Location = new System.Drawing.Point(11, 149);
            this.resultadoTesteLabel.Name = "resultadoTesteLabel";
            this.resultadoTesteLabel.Size = new System.Drawing.Size(58, 13);
            this.resultadoTesteLabel.TabIndex = 23;
            this.resultadoTesteLabel.Text = "Resultado:";
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(15, 370);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 24;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(111, 370);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 25;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(218, 370);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 26;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(321, 369);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 27;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 71);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 29;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(111, 64);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(272, 20);
            this.nomeTextBox.TabIndex = 28;
            // 
            // resultadoPanel
            // 
            this.resultadoPanel.Controls.Add(this.positivoRadioButton);
            this.resultadoPanel.Controls.Add(this.negativoRadioButton);
            this.resultadoPanel.Location = new System.Drawing.Point(111, 143);
            this.resultadoPanel.Name = "resultadoPanel";
            this.resultadoPanel.Size = new System.Drawing.Size(128, 61);
            this.resultadoPanel.TabIndex = 31;
            // 
            // positivoRadioButton
            // 
            this.positivoRadioButton.AutoSize = true;
            this.positivoRadioButton.Location = new System.Drawing.Point(16, 29);
            this.positivoRadioButton.Name = "positivoRadioButton";
            this.positivoRadioButton.Size = new System.Drawing.Size(62, 17);
            this.positivoRadioButton.TabIndex = 32;
            this.positivoRadioButton.Text = "Positivo";
            this.positivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // negativoRadioButton
            // 
            this.negativoRadioButton.AutoSize = true;
            this.negativoRadioButton.Checked = true;
            this.negativoRadioButton.Location = new System.Drawing.Point(16, 6);
            this.negativoRadioButton.Name = "negativoRadioButton";
            this.negativoRadioButton.Size = new System.Drawing.Size(68, 17);
            this.negativoRadioButton.TabIndex = 31;
            this.negativoRadioButton.TabStop = true;
            this.negativoRadioButton.Text = "Negativo";
            this.negativoRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormTesteCovid19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 405);
            this.Controls.Add(this.resultadoPanel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.resultadoTesteLabel);
            this.Controls.Add(this.dataTesteLabel);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.codigoTesteCovid19Label);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(this.dataTesteDateTimePicker);
            this.Controls.Add(this.testeCovid19ListBox);
            this.Controls.Add(this.obterListaButton);
            this.Controls.Add(this.codigoTesteCovid19TextBox);
            this.Controls.Add(this.componenteMenuStrip);
            this.MainMenuStrip = this.componenteMenuStrip;
            this.Name = "FormTesteCovid19";
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.FormTesteCovid19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testeCovid19ErrorProvider)).EndInit();
            this.componenteMenuStrip.ResumeLayout(false);
            this.componenteMenuStrip.PerformLayout();
            this.resultadoPanel.ResumeLayout(false);
            this.resultadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTesteCovid19TextBox;
        private System.Windows.Forms.ErrorProvider testeCovid19ErrorProvider;
        private System.Windows.Forms.ListBox testeCovid19ListBox;
        private System.Windows.Forms.Button obterListaButton;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.DateTimePicker dataTesteDateTimePicker;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label dataTesteLabel;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.Label codigoTesteCovid19Label;
        private System.Windows.Forms.MenuStrip componenteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Label resultadoTesteLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Panel resultadoPanel;
        private System.Windows.Forms.RadioButton positivoRadioButton;
        private System.Windows.Forms.RadioButton negativoRadioButton;
    }
}

