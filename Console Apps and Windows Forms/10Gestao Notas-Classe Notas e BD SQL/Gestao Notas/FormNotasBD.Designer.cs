namespace Gestao_Notas
{
    partial class FormNotasBD
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
            this.ButtonSair = new System.Windows.Forms.Button();
            this.ButtonInserir = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.ButtonAlterar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBoxNumero = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxNotaTeste = new System.Windows.Forms.TextBox();
            this.dataGridViewEstudantes = new System.Windows.Forms.DataGridView();
            this.Label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNotaTrabalho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSair.ForeColor = System.Drawing.Color.Black;
            this.ButtonSair.Location = new System.Drawing.Point(517, 394);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(108, 41);
            this.ButtonSair.TabIndex = 9;
            this.ButtonSair.Text = "Saír";
            this.ButtonSair.UseVisualStyleBackColor = false;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // ButtonInserir
            // 
            this.ButtonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInserir.ForeColor = System.Drawing.Color.Black;
            this.ButtonInserir.Location = new System.Drawing.Point(34, 162);
            this.ButtonInserir.Name = "ButtonInserir";
            this.ButtonInserir.Size = new System.Drawing.Size(110, 30);
            this.ButtonInserir.TabIndex = 4;
            this.ButtonInserir.Text = "Inserir registo";
            this.ButtonInserir.UseVisualStyleBackColor = false;
            this.ButtonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.ForeColor = System.Drawing.Color.Black;
            this.ButtonEliminar.Location = new System.Drawing.Point(275, 162);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(110, 30);
            this.ButtonEliminar.TabIndex = 6;
            this.ButtonEliminar.Text = "Eliminar registo";
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovo.ForeColor = System.Drawing.Color.Black;
            this.ButtonNovo.Location = new System.Drawing.Point(515, 162);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(110, 30);
            this.ButtonNovo.TabIndex = 7;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlterar.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlterar.Location = new System.Drawing.Point(152, 162);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(110, 30);
            this.ButtonAlterar.TabIndex = 5;
            this.ButtonAlterar.Text = "Alterar registo";
            this.ButtonAlterar.UseVisualStyleBackColor = false;
            this.ButtonAlterar.Click += new System.EventHandler(this.ButtonAlterar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(28, 29);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 16);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Numero:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(28, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "Nome:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(30, 91);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 16);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Nota teste:";
            // 
            // TextBoxNumero
            // 
            this.TextBoxNumero.Location = new System.Drawing.Point(129, 29);
            this.TextBoxNumero.Name = "TextBoxNumero";
            this.TextBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumero.TabIndex = 0;
            this.TextBoxNumero.TextChanged += new System.EventHandler(this.TextBoxNumero_TextChanged);
            this.TextBoxNumero.Leave += new System.EventHandler(this.TextBoxNumero_Leave);
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(129, 60);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(351, 20);
            this.TextBoxNome.TabIndex = 1;
            // 
            // TextBoxNotaTeste
            // 
            this.TextBoxNotaTeste.Location = new System.Drawing.Point(129, 91);
            this.TextBoxNotaTeste.Name = "TextBoxNotaTeste";
            this.TextBoxNotaTeste.Size = new System.Drawing.Size(41, 20);
            this.TextBoxNotaTeste.TabIndex = 2;
            // 
            // dataGridViewEstudantes
            // 
            this.dataGridViewEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudantes.Location = new System.Drawing.Point(34, 229);
            this.dataGridViewEstudantes.Name = "dataGridViewEstudantes";
            this.dataGridViewEstudantes.Size = new System.Drawing.Size(591, 150);
            this.dataGridViewEstudantes.TabIndex = 8;
            this.dataGridViewEstudantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstudantes_CellContentClick);
            this.dataGridViewEstudantes.SelectionChanged += new System.EventHandler(this.dataGridViewEstudantes_SelectionChanged);
            this.dataGridViewEstudantes.Enter += new System.EventHandler(this.dataGridViewEstudantes_Enter);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(32, 213);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 13);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "Lista de estudantes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nota trabalho:";
            // 
            // TextBoxNotaTrabalho
            // 
            this.TextBoxNotaTrabalho.Location = new System.Drawing.Point(129, 122);
            this.TextBoxNotaTrabalho.Name = "TextBoxNotaTrabalho";
            this.TextBoxNotaTrabalho.Size = new System.Drawing.Size(41, 20);
            this.TextBoxNotaTrabalho.TabIndex = 3;
            // 
            // FormNotasBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dataGridViewEstudantes);
            this.Controls.Add(this.TextBoxNotaTrabalho);
            this.Controls.Add(this.TextBoxNotaTeste);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNumero);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ButtonAlterar);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonInserir);
            this.Name = "FormNotasBD";
            this.Text = "FormNotasBD";
            this.Load += new System.EventHandler(this.FormNotasBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonSair;
        internal System.Windows.Forms.Button ButtonInserir;
        internal System.Windows.Forms.Button ButtonEliminar;
        internal System.Windows.Forms.Button ButtonNovo;
        internal System.Windows.Forms.Button ButtonAlterar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBoxNumero;
        internal System.Windows.Forms.TextBox TextBoxNome;
        internal System.Windows.Forms.TextBox TextBoxNotaTeste;
        private System.Windows.Forms.DataGridView dataGridViewEstudantes;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox TextBoxNotaTrabalho;
    }
}