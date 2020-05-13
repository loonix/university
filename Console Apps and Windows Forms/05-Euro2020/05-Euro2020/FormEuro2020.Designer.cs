namespace _05_Euro2020
{
    partial class FormEuro2020
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeroEstadio = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeEstadio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalJogos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalAssistencias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCapacidade = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardarFicheiro = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Estádio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "País";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cidade";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Capacidade";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jogos";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Assistencias";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Estado";
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Estádio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNumeroEstadio
            // 
            this.textBoxNumeroEstadio.Location = new System.Drawing.Point(96, 190);
            this.textBoxNumeroEstadio.Name = "textBoxNumeroEstadio";
            this.textBoxNumeroEstadio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroEstadio.TabIndex = 2;
            this.textBoxNumeroEstadio.Leave += new System.EventHandler(this.textBoxNumeroEstadio_Leave);
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(96, 222);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "País";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(96, 258);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCidade.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cidade";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Estádio";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNomeEstadio
            // 
            this.textBoxNomeEstadio.Location = new System.Drawing.Point(96, 288);
            this.textBoxNomeEstadio.Name = "textBoxNomeEstadio";
            this.textBoxNomeEstadio.Size = new System.Drawing.Size(308, 20);
            this.textBoxNomeEstadio.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Jogos";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTotalJogos
            // 
            this.textBoxTotalJogos.Location = new System.Drawing.Point(527, 190);
            this.textBoxTotalJogos.Name = "textBoxTotalJogos";
            this.textBoxTotalJogos.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalJogos.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Assistências";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTotalAssistencias
            // 
            this.textBoxTotalAssistencias.Location = new System.Drawing.Point(532, 223);
            this.textBoxTotalAssistencias.Name = "textBoxTotalAssistencias";
            this.textBoxTotalAssistencias.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAssistencias.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Capacidade";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCapacidade
            // 
            this.textBoxCapacidade.Location = new System.Drawing.Point(532, 255);
            this.textBoxCapacidade.Name = "textBoxCapacidade";
            this.textBoxCapacidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapacidade.TabIndex = 2;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(12, 325);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(171, 30);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(183, 325);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(171, 30);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(354, 325);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(171, 30);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(525, 325);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(171, 30);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonGuardarFicheiro
            // 
            this.buttonGuardarFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarFicheiro.Location = new System.Drawing.Point(759, 325);
            this.buttonGuardarFicheiro.Name = "buttonGuardarFicheiro";
            this.buttonGuardarFicheiro.Size = new System.Drawing.Size(144, 30);
            this.buttonGuardarFicheiro.TabIndex = 3;
            this.buttonGuardarFicheiro.Text = "Guardar em Ficheiro";
            this.buttonGuardarFicheiro.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(909, 325);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 30);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormEuro2020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 364);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardarFicheiro);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeEstadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCapacidade);
            this.Controls.Add(this.textBoxTotalAssistencias);
            this.Controls.Add(this.textBoxTotalJogos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumeroEstadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEuro2020";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEuro2020_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeroEstadio;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeEstadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalJogos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalAssistencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCapacidade;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardarFicheiro;
        private System.Windows.Forms.Button buttonSair;
    }
}