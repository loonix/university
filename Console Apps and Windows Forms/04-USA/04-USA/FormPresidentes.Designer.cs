namespace _04_USA
{
    partial class FormPresidentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxAnoInicio = new System.Windows.Forms.ComboBox();
            this.comboBoxAnoFim = new System.Windows.Forms.ComboBox();
            this.comboBoxPartido = new System.Windows.Forms.ComboBox();
            this.buttonAdiciona = new System.Windows.Forms.Button();
            this.buttonVisualiza = new System.Windows.Forms.Button();
            this.buttonGuardarFicheiro = new System.Windows.Forms.Button();
            this.buttonAbrirFicheiro = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ano inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ano fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Partido:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(129, 31);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(245, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // comboBoxAnoInicio
            // 
            this.comboBoxAnoInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAnoInicio.FormattingEnabled = true;
            this.comboBoxAnoInicio.Location = new System.Drawing.Point(129, 102);
            this.comboBoxAnoInicio.Name = "comboBoxAnoInicio";
            this.comboBoxAnoInicio.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAnoInicio.TabIndex = 2;
            // 
            // comboBoxAnoFim
            // 
            this.comboBoxAnoFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnoFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAnoFim.FormattingEnabled = true;
            this.comboBoxAnoFim.Location = new System.Drawing.Point(129, 168);
            this.comboBoxAnoFim.Name = "comboBoxAnoFim";
            this.comboBoxAnoFim.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAnoFim.TabIndex = 2;
            // 
            // comboBoxPartido
            // 
            this.comboBoxPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPartido.FormattingEnabled = true;
            this.comboBoxPartido.Items.AddRange(new object[] {
            "Sem partido",
            "Democrata",
            "Democrata-Republicano",
            "Federalista",
            "Republicano"});
            this.comboBoxPartido.Location = new System.Drawing.Point(129, 245);
            this.comboBoxPartido.Name = "comboBoxPartido";
            this.comboBoxPartido.Size = new System.Drawing.Size(187, 28);
            this.comboBoxPartido.TabIndex = 2;
            // 
            // buttonAdiciona
            // 
            this.buttonAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdiciona.Location = new System.Drawing.Point(129, 309);
            this.buttonAdiciona.Name = "buttonAdiciona";
            this.buttonAdiciona.Size = new System.Drawing.Size(187, 65);
            this.buttonAdiciona.TabIndex = 3;
            this.buttonAdiciona.Text = "Adicionar Registo à coleção List";
            this.buttonAdiciona.UseVisualStyleBackColor = true;
            this.buttonAdiciona.Click += new System.EventHandler(this.buttonAdiciona_Click);
            // 
            // buttonVisualiza
            // 
            this.buttonVisualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualiza.Location = new System.Drawing.Point(601, 32);
            this.buttonVisualiza.Name = "buttonVisualiza";
            this.buttonVisualiza.Size = new System.Drawing.Size(187, 65);
            this.buttonVisualiza.TabIndex = 3;
            this.buttonVisualiza.Text = "Visualizar Presidentes";
            this.buttonVisualiza.UseVisualStyleBackColor = true;
            this.buttonVisualiza.Click += new System.EventHandler(this.buttonVisualiza_Click);
            // 
            // buttonGuardarFicheiro
            // 
            this.buttonGuardarFicheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGuardarFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarFicheiro.Location = new System.Drawing.Point(601, 131);
            this.buttonGuardarFicheiro.Name = "buttonGuardarFicheiro";
            this.buttonGuardarFicheiro.Size = new System.Drawing.Size(187, 65);
            this.buttonGuardarFicheiro.TabIndex = 3;
            this.buttonGuardarFicheiro.Text = "Guardar em ficheiro de texto";
            this.buttonGuardarFicheiro.UseVisualStyleBackColor = false;
            this.buttonGuardarFicheiro.Click += new System.EventHandler(this.buttonGuardarFicheiro_Click);
            // 
            // buttonAbrirFicheiro
            // 
            this.buttonAbrirFicheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAbrirFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirFicheiro.Location = new System.Drawing.Point(601, 226);
            this.buttonAbrirFicheiro.Name = "buttonAbrirFicheiro";
            this.buttonAbrirFicheiro.Size = new System.Drawing.Size(187, 65);
            this.buttonAbrirFicheiro.TabIndex = 3;
            this.buttonAbrirFicheiro.Text = "Abrir ficheiro de texto";
            this.buttonAbrirFicheiro.UseVisualStyleBackColor = false;
            this.buttonAbrirFicheiro.Click += new System.EventHandler(this.buttonAbrirFicheiro_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(695, 397);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(93, 41);
            this.buttonFechar.TabIndex = 3;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // FormPresidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbrirFicheiro);
            this.Controls.Add(this.buttonGuardarFicheiro);
            this.Controls.Add(this.buttonVisualiza);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonAdiciona);
            this.Controls.Add(this.comboBoxPartido);
            this.Controls.Add(this.comboBoxAnoFim);
            this.Controls.Add(this.comboBoxAnoInicio);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPresidentes";
            this.Text = "FormPresidentes";
            this.Load += new System.EventHandler(this.FormPresidentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxAnoInicio;
        private System.Windows.Forms.ComboBox comboBoxAnoFim;
        private System.Windows.Forms.ComboBox comboBoxPartido;
        private System.Windows.Forms.Button buttonAdiciona;
        private System.Windows.Forms.Button buttonVisualiza;
        private System.Windows.Forms.Button buttonGuardarFicheiro;
        private System.Windows.Forms.Button buttonAbrirFicheiro;
        private System.Windows.Forms.Button buttonFechar;
    }
}