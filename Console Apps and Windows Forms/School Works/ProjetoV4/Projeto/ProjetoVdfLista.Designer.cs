namespace ExemploProjeto
{
    partial class ProjetoVdfLista
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.totalPedidosLabel = new System.Windows.Forms.Label();
            this.totalInProgressLabel = new System.Windows.Forms.Label();
            this.pedidosPorFecharSuperior2SemanasLabel = new System.Windows.Forms.Label();
            this.pegunta1Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalOnHoldLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalInfoPendLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalSubCasePendLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.totalClosedLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totalProposalLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomePreVendaComboBox = new System.Windows.Forms.ComboBox();
            this.mesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(798, 367);
            this.dataGridView.TabIndex = 43;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // totalPedidosLabel
            // 
            this.totalPedidosLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPedidosLabel.Location = new System.Drawing.Point(241, 407);
            this.totalPedidosLabel.Name = "totalPedidosLabel";
            this.totalPedidosLabel.Size = new System.Drawing.Size(49, 23);
            this.totalPedidosLabel.TabIndex = 44;
            // 
            // totalInProgressLabel
            // 
            this.totalInProgressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalInProgressLabel.Location = new System.Drawing.Point(241, 442);
            this.totalInProgressLabel.Name = "totalInProgressLabel";
            this.totalInProgressLabel.Size = new System.Drawing.Size(49, 23);
            this.totalInProgressLabel.TabIndex = 44;
            // 
            // pedidosPorFecharSuperior2SemanasLabel
            // 
            this.pedidosPorFecharSuperior2SemanasLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pedidosPorFecharSuperior2SemanasLabel.Location = new System.Drawing.Point(664, 616);
            this.pedidosPorFecharSuperior2SemanasLabel.Name = "pedidosPorFecharSuperior2SemanasLabel";
            this.pedidosPorFecharSuperior2SemanasLabel.Size = new System.Drawing.Size(49, 23);
            this.pedidosPorFecharSuperior2SemanasLabel.TabIndex = 44;
            this.pedidosPorFecharSuperior2SemanasLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pegunta1Label
            // 
            this.pegunta1Label.AutoSize = true;
            this.pegunta1Label.Location = new System.Drawing.Point(46, 417);
            this.pegunta1Label.Name = "pegunta1Label";
            this.pegunta1Label.Size = new System.Drawing.Size(105, 13);
            this.pegunta1Label.TabIndex = 45;
            this.pegunta1Label.Text = "Total nº de pedidos?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nº de pedidos In Progress?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nº de Pedidos pro fechar à mais de 2 semanas?\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nome do Pré Venda:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Mês:";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // totalOnHoldLabel
            // 
            this.totalOnHoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOnHoldLabel.Location = new System.Drawing.Point(241, 477);
            this.totalOnHoldLabel.Name = "totalOnHoldLabel";
            this.totalOnHoldLabel.Size = new System.Drawing.Size(49, 23);
            this.totalOnHoldLabel.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nº de pedidos On Hold?";
            // 
            // totalInfoPendLabel
            // 
            this.totalInfoPendLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalInfoPendLabel.Location = new System.Drawing.Point(241, 512);
            this.totalInfoPendLabel.Name = "totalInfoPendLabel";
            this.totalInfoPendLabel.Size = new System.Drawing.Size(49, 23);
            this.totalInfoPendLabel.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 522);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Nº de pedidos Info Pend?";
            // 
            // totalSubCasePendLabel
            // 
            this.totalSubCasePendLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSubCasePendLabel.Location = new System.Drawing.Point(241, 547);
            this.totalSubCasePendLabel.Name = "totalSubCasePendLabel";
            this.totalSubCasePendLabel.Size = new System.Drawing.Size(49, 23);
            this.totalSubCasePendLabel.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nº de pedidos em Sub Case Pend?";
            // 
            // totalClosedLabel
            // 
            this.totalClosedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalClosedLabel.Location = new System.Drawing.Point(241, 582);
            this.totalClosedLabel.Name = "totalClosedLabel";
            this.totalClosedLabel.Size = new System.Drawing.Size(49, 23);
            this.totalClosedLabel.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 592);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Nº de pedidos Close Pend?";
            // 
            // totalProposalLabel
            // 
            this.totalProposalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalProposalLabel.Location = new System.Drawing.Point(240, 616);
            this.totalProposalLabel.Name = "totalProposalLabel";
            this.totalProposalLabel.Size = new System.Drawing.Size(49, 23);
            this.totalProposalLabel.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 626);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Nº de pedidos Proposal?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Filtrar por:";
            this.label5.Click += new System.EventHandler(this.label6_Click);
            // 
            // nomePreVendaComboBox
            // 
            this.nomePreVendaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nomePreVendaComboBox.FormattingEnabled = true;
            this.nomePreVendaComboBox.Location = new System.Drawing.Point(502, 414);
            this.nomePreVendaComboBox.Name = "nomePreVendaComboBox";
            this.nomePreVendaComboBox.Size = new System.Drawing.Size(150, 21);
            this.nomePreVendaComboBox.TabIndex = 46;
            this.nomePreVendaComboBox.SelectedIndexChanged += new System.EventHandler(this.nomePreVendaComboBox_SelectedIndexChanged);
            // 
            // mesComboBox
            // 
            this.mesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesComboBox.FormattingEnabled = true;
            this.mesComboBox.Location = new System.Drawing.Point(502, 444);
            this.mesComboBox.Name = "mesComboBox";
            this.mesComboBox.Size = new System.Drawing.Size(121, 21);
            this.mesComboBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ano:";
            this.label1.Click += new System.EventHandler(this.label6_Click);
            // 
            // anoComboBox
            // 
            this.anoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anoComboBox.FormattingEnabled = true;
            this.anoComboBox.Location = new System.Drawing.Point(502, 475);
            this.anoComboBox.Name = "anoComboBox";
            this.anoComboBox.Size = new System.Drawing.Size(121, 21);
            this.anoComboBox.TabIndex = 47;
            // 
            // ProjetoVdfLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 685);
            this.Controls.Add(this.nomePreVendaComboBox);
            this.Controls.Add(this.anoComboBox);
            this.Controls.Add(this.mesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalProposalLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalClosedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalSubCasePendLabel);
            this.Controls.Add(this.pegunta1Label);
            this.Controls.Add(this.totalInfoPendLabel);
            this.Controls.Add(this.pedidosPorFecharSuperior2SemanasLabel);
            this.Controls.Add(this.totalOnHoldLabel);
            this.Controls.Add(this.totalInProgressLabel);
            this.Controls.Add(this.totalPedidosLabel);
            this.Controls.Add(this.dataGridView);
            this.Name = "ProjetoVdfLista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProjetoVdfLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label totalPedidosLabel;
        private System.Windows.Forms.Label totalInProgressLabel;
        private System.Windows.Forms.Label pedidosPorFecharSuperior2SemanasLabel;
        private System.Windows.Forms.Label pegunta1Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalOnHoldLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalInfoPendLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalSubCasePendLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label totalClosedLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label totalProposalLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nomePreVendaComboBox;
        private System.Windows.Forms.ComboBox mesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anoComboBox;
    }
}