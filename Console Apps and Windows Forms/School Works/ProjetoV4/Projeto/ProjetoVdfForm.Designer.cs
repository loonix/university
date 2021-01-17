namespace ExemploProjeto
{
    partial class ProjetoVdfForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.projetoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.listaButton = new System.Windows.Forms.Button();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.dataInicioPedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataAdjudicacaoLabel = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.idWoTextBox = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.idWoLabel = new System.Windows.Forms.Label();
            this.duracaoContratoLabel = new System.Windows.Forms.Label();
            this.duracaoContratoComboBox = new System.Windows.Forms.ComboBox();
            this.longitudeLabel2 = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderProjetoVdf = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipoNegocioLabel = new System.Windows.Forms.Label();
            this.tipoNegocioUserControl = new ExemploProjeto.TipoNegocioUserControl();
            this.estadoNegocioUserControl = new ExemploProjeto.EstadoNegocioUserControl();
            this.estadoNegocioLabel = new System.Windows.Forms.Label();
            this.nomePVLabel = new System.Windows.Forms.Label();
            this.nomePVComboBox = new System.Windows.Forms.ComboBox();
            this.coordenadasGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.projetoMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjetoVdf)).BeginInit();
            this.coordenadasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // projetoMenuStrip
            // 
            this.projetoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.projetoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.projetoMenuStrip.Name = "projetoMenuStrip";
            this.projetoMenuStrip.Size = new System.Drawing.Size(1017, 24);
            this.projetoMenuStrip.TabIndex = 1;
            this.projetoMenuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.gravarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.abrirToolStripMenuItem.Text = "Novo";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.novo_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.abrirToolStripMenuItem1.Text = "Gravar";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.gravar_Click);
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gravarToolStripMenuItem.Text = "Eliminar";
            this.gravarToolStripMenuItem.Click += new System.EventHandler(this.eliminar_Click);
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
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(101, 6);
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(518, 118);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 19;
            this.sairButton.Text = "&Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sair_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(518, 29);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 18;
            this.novoButton.Text = "&Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novo_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(518, 89);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 17;
            this.eliminarButton.Text = "&Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(518, 60);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 16;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravar_Click);
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(264, 32);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(41, 20);
            this.listaButton.TabIndex = 30;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.latitudeTextBox.Location = new System.Drawing.Point(84, 24);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.latitudeTextBox.TabIndex = 29;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(16, 31);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(48, 13);
            this.latitudeLabel.TabIndex = 28;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // dataInicioPedidoDateTimePicker
            // 
            this.dataInicioPedidoDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dataInicioPedidoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicioPedidoDateTimePicker.Location = new System.Drawing.Point(79, 130);
            this.dataInicioPedidoDateTimePicker.Name = "dataInicioPedidoDateTimePicker";
            this.dataInicioPedidoDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dataInicioPedidoDateTimePicker.TabIndex = 27;
            // 
            // dataAdjudicacaoLabel
            // 
            this.dataAdjudicacaoLabel.AutoSize = true;
            this.dataAdjudicacaoLabel.Location = new System.Drawing.Point(19, 136);
            this.dataAdjudicacaoLabel.Name = "dataAdjudicacaoLabel";
            this.dataAdjudicacaoLabel.Size = new System.Drawing.Size(33, 13);
            this.dataAdjudicacaoLabel.TabIndex = 26;
            this.dataAdjudicacaoLabel.Text = "Data:";
            this.dataAdjudicacaoLabel.Click += new System.EventHandler(this.dataInicioPedidoLabel_Click);
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteTextBox.Location = new System.Drawing.Point(79, 62);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(403, 20);
            this.clienteTextBox.TabIndex = 24;
            // 
            // idWoTextBox
            // 
            this.idWoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idWoTextBox.Location = new System.Drawing.Point(80, 32);
            this.idWoTextBox.Name = "idWoTextBox";
            this.idWoTextBox.Size = new System.Drawing.Size(166, 20);
            this.idWoTextBox.TabIndex = 23;
            this.idWoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idWoTextBox_KeyUp);
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(14, 65);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(42, 13);
            this.clienteLabel.TabIndex = 22;
            this.clienteLabel.Text = "Cliente:";
            // 
            // idWoLabel
            // 
            this.idWoLabel.AutoSize = true;
            this.idWoLabel.Location = new System.Drawing.Point(15, 35);
            this.idWoLabel.Name = "idWoLabel";
            this.idWoLabel.Size = new System.Drawing.Size(41, 13);
            this.idWoLabel.TabIndex = 21;
            this.idWoLabel.Text = "ID Wo:";
            // 
            // duracaoContratoLabel
            // 
            this.duracaoContratoLabel.AutoSize = true;
            this.duracaoContratoLabel.Location = new System.Drawing.Point(250, 99);
            this.duracaoContratoLabel.Name = "duracaoContratoLabel";
            this.duracaoContratoLabel.Size = new System.Drawing.Size(94, 13);
            this.duracaoContratoLabel.TabIndex = 32;
            this.duracaoContratoLabel.Text = "Duração Contrato:";
            // 
            // duracaoContratoComboBox
            // 
            this.duracaoContratoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duracaoContratoComboBox.FormattingEnabled = true;
            this.duracaoContratoComboBox.Location = new System.Drawing.Point(361, 96);
            this.duracaoContratoComboBox.Name = "duracaoContratoComboBox";
            this.duracaoContratoComboBox.Size = new System.Drawing.Size(121, 21);
            this.duracaoContratoComboBox.TabIndex = 33;
            // 
            // longitudeLabel2
            // 
            this.longitudeLabel2.AutoSize = true;
            this.longitudeLabel2.Location = new System.Drawing.Point(16, 56);
            this.longitudeLabel2.Name = "longitudeLabel2";
            this.longitudeLabel2.Size = new System.Drawing.Size(57, 13);
            this.longitudeLabel2.TabIndex = 34;
            this.longitudeLabel2.Text = "Longitude:";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.longitudeTextBox.Location = new System.Drawing.Point(84, 49);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeTextBox.TabIndex = 35;
            // 
            // errorProviderProjetoVdf
            // 
            this.errorProviderProjetoVdf.ContainerControl = this;
            // 
            // tipoNegocioLabel
            // 
            this.tipoNegocioLabel.AutoSize = true;
            this.tipoNegocioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoNegocioLabel.Location = new System.Drawing.Point(275, 198);
            this.tipoNegocioLabel.Name = "tipoNegocioLabel";
            this.tipoNegocioLabel.Size = new System.Drawing.Size(113, 16);
            this.tipoNegocioLabel.TabIndex = 39;
            this.tipoNegocioLabel.Text = "Tipo de Negocio:";
            // 
            // tipoNegocioUserControl
            // 
            this.tipoNegocioUserControl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tipoNegocioUserControl.Location = new System.Drawing.Point(278, 217);
            this.tipoNegocioUserControl.Name = "tipoNegocioUserControl";
            this.tipoNegocioUserControl.Size = new System.Drawing.Size(150, 164);
            this.tipoNegocioUserControl.TabIndex = 38;
            this.tipoNegocioUserControl.TipoNegocio = CamadaNegocio.TipoNegocioEnum.Ataque;
            // 
            // estadoNegocioUserControl
            // 
            this.estadoNegocioUserControl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.estadoNegocioUserControl.EstadoNegocio = CamadaNegocio.EstadoNegocioEnum.Nada;
            this.estadoNegocioUserControl.Location = new System.Drawing.Point(430, 217);
            this.estadoNegocioUserControl.Name = "estadoNegocioUserControl";
            this.estadoNegocioUserControl.Size = new System.Drawing.Size(144, 164);
            this.estadoNegocioUserControl.TabIndex = 40;
            // 
            // estadoNegocioLabel
            // 
            this.estadoNegocioLabel.AutoSize = true;
            this.estadoNegocioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoNegocioLabel.Location = new System.Drawing.Point(427, 198);
            this.estadoNegocioLabel.Name = "estadoNegocioLabel";
            this.estadoNegocioLabel.Size = new System.Drawing.Size(128, 16);
            this.estadoNegocioLabel.TabIndex = 39;
            this.estadoNegocioLabel.Text = "Estado de Negocio:";
            // 
            // nomePVLabel
            // 
            this.nomePVLabel.AutoSize = true;
            this.nomePVLabel.Location = new System.Drawing.Point(15, 99);
            this.nomePVLabel.Name = "nomePVLabel";
            this.nomePVLabel.Size = new System.Drawing.Size(55, 13);
            this.nomePVLabel.TabIndex = 34;
            this.nomePVLabel.Text = "Nome PV:";
            // 
            // nomePVComboBox
            // 
            this.nomePVComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomePVComboBox.FormattingEnabled = true;
            this.nomePVComboBox.Location = new System.Drawing.Point(80, 94);
            this.nomePVComboBox.Name = "nomePVComboBox";
            this.nomePVComboBox.Size = new System.Drawing.Size(150, 21);
            this.nomePVComboBox.TabIndex = 33;
            // 
            // coordenadasGroupBox
            // 
            this.coordenadasGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coordenadasGroupBox.Controls.Add(this.longitudeTextBox);
            this.coordenadasGroupBox.Controls.Add(this.latitudeLabel);
            this.coordenadasGroupBox.Controls.Add(this.latitudeTextBox);
            this.coordenadasGroupBox.Controls.Add(this.longitudeLabel2);
            this.coordenadasGroupBox.Location = new System.Drawing.Point(46, 217);
            this.coordenadasGroupBox.Name = "coordenadasGroupBox";
            this.coordenadasGroupBox.Size = new System.Drawing.Size(200, 100);
            this.coordenadasGroupBox.TabIndex = 41;
            this.coordenadasGroupBox.TabStop = false;
            this.coordenadasGroupBox.Text = "Coordenadas Geográficas";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(614, 29);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(382, 352);
            this.dataGridView.TabIndex = 42;
            // 
            // ProjetoVdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 428);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.coordenadasGroupBox);
            this.Controls.Add(this.estadoNegocioUserControl);
            this.Controls.Add(this.estadoNegocioLabel);
            this.Controls.Add(this.tipoNegocioLabel);
            this.Controls.Add(this.tipoNegocioUserControl);
            this.Controls.Add(this.nomePVLabel);
            this.Controls.Add(this.nomePVComboBox);
            this.Controls.Add(this.duracaoContratoComboBox);
            this.Controls.Add(this.duracaoContratoLabel);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.dataInicioPedidoDateTimePicker);
            this.Controls.Add(this.dataAdjudicacaoLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.idWoTextBox);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.idWoLabel);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.projetoMenuStrip);
            this.Name = "ProjetoVdfForm";
            this.Text = "Projeto Vodafone";
            this.Load += new System.EventHandler(this.ProjetoVdfForm_Load);
            this.projetoMenuStrip.ResumeLayout(false);
            this.projetoMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProjetoVdf)).EndInit();
            this.coordenadasGroupBox.ResumeLayout(false);
            this.coordenadasGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip projetoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gravarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.DateTimePicker dataInicioPedidoDateTimePicker;
        private System.Windows.Forms.Label dataAdjudicacaoLabel;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox idWoTextBox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label idWoLabel;
        private System.Windows.Forms.Label duracaoContratoLabel;
        private System.Windows.Forms.ComboBox duracaoContratoComboBox;
        private System.Windows.Forms.Label longitudeLabel2;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderProjetoVdf;
        private System.Windows.Forms.Label tipoNegocioLabel;
        private TipoNegocioUserControl tipoNegocioUserControl;
        private EstadoNegocioUserControl estadoNegocioUserControl;
        private System.Windows.Forms.Label estadoNegocioLabel;
        private System.Windows.Forms.GroupBox coordenadasGroupBox;
        private System.Windows.Forms.Label nomePVLabel;
        private System.Windows.Forms.ComboBox nomePVComboBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}