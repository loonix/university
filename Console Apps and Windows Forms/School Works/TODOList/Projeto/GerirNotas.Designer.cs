namespace CamadaNegocio
{
    partial class GerirNotas
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
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.mostrarExpiradosCheckBox = new System.Windows.Forms.CheckBox();
            this.mostrarEmDestaqueCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editarBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.pesquisaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(700, 197);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.SlateGray;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelarBtn.Location = new System.Drawing.Point(718, 207);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(109, 45);
            this.cancelarBtn.TabIndex = 8;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.adicionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.adicionarBtn.Location = new System.Drawing.Point(718, 156);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(109, 45);
            this.adicionarBtn.TabIndex = 4;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = false;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // mostrarExpiradosCheckBox
            // 
            this.mostrarExpiradosCheckBox.AutoSize = true;
            this.mostrarExpiradosCheckBox.Location = new System.Drawing.Point(106, 271);
            this.mostrarExpiradosCheckBox.Name = "mostrarExpiradosCheckBox";
            this.mostrarExpiradosCheckBox.Size = new System.Drawing.Size(110, 17);
            this.mostrarExpiradosCheckBox.TabIndex = 5;
            this.mostrarExpiradosCheckBox.Text = "Mostrar Expirados";
            this.mostrarExpiradosCheckBox.UseVisualStyleBackColor = true;
            this.mostrarExpiradosCheckBox.CheckedChanged += new System.EventHandler(this.mostrarExpiradosCheckBox_CheckedChanged);
            // 
            // mostrarEmDestaqueCheckBox
            // 
            this.mostrarEmDestaqueCheckBox.AutoSize = true;
            this.mostrarEmDestaqueCheckBox.Location = new System.Drawing.Point(234, 271);
            this.mostrarEmDestaqueCheckBox.Name = "mostrarEmDestaqueCheckBox";
            this.mostrarEmDestaqueCheckBox.Size = new System.Drawing.Size(128, 17);
            this.mostrarEmDestaqueCheckBox.TabIndex = 6;
            this.mostrarEmDestaqueCheckBox.Text = "Mostrar Em Destaque";
            this.mostrarEmDestaqueCheckBox.UseVisualStyleBackColor = true;
            this.mostrarEmDestaqueCheckBox.CheckedChanged += new System.EventHandler(this.mostrarEmDestaqueCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerir Notas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filtros";
            // 
            // editarBtn
            // 
            this.editarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.editarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editarBtn.Location = new System.Drawing.Point(718, 54);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(109, 45);
            this.editarBtn.TabIndex = 2;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // removerBtn
            // 
            this.removerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removerBtn.BackColor = System.Drawing.Color.Crimson;
            this.removerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.removerBtn.Location = new System.Drawing.Point(718, 105);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(109, 45);
            this.removerBtn.TabIndex = 3;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = false;
            this.removerBtn.Click += new System.EventHandler(this.removerBtn_Click);
            // 
            // pesquisaTextBox
            // 
            this.pesquisaTextBox.Location = new System.Drawing.Point(383, 268);
            this.pesquisaTextBox.Name = "pesquisaTextBox";
            this.pesquisaTextBox.Size = new System.Drawing.Size(247, 20);
            this.pesquisaTextBox.TabIndex = 7;
            this.pesquisaTextBox.TextChanged += new System.EventHandler(this.pesquisa_TextChanged);
            // 
            // GerirNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 304);
            this.Controls.Add(this.pesquisaTextBox);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mostrarEmDestaqueCheckBox);
            this.Controls.Add(this.mostrarExpiradosCheckBox);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "GerirNotas";
            this.Text = "GerirNotas";
            this.Load += new System.EventHandler(this.GerirNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.CheckBox mostrarExpiradosCheckBox;
        private System.Windows.Forms.CheckBox mostrarEmDestaqueCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.TextBox pesquisaTextBox;
    }
}