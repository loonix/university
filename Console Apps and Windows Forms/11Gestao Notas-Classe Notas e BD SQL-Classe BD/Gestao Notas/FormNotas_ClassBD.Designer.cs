namespace Gestao_Notas
{
    partial class FormNotas_ClassBD
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
            this.Label6 = new System.Windows.Forms.Label();
            this.dataGridViewEstudantes = new System.Windows.Forms.DataGridView();
            this.TextBoxNotaTrabalho = new System.Windows.Forms.TextBox();
            this.TextBoxNotaTeste = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNumero = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButtonAlterar = new System.Windows.Forms.Button();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSair.ForeColor = System.Drawing.Color.Black;
            this.ButtonSair.Location = new System.Drawing.Point(591, 387);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(108, 41);
            this.ButtonSair.TabIndex = 61;
            this.ButtonSair.Text = "Saír";
            this.ButtonSair.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(106, 206);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 13);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "Lista de estudantes:";
            // 
            // dataGridViewEstudantes
            // 
            this.dataGridViewEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudantes.Location = new System.Drawing.Point(108, 222);
            this.dataGridViewEstudantes.Name = "dataGridViewEstudantes";
            this.dataGridViewEstudantes.Size = new System.Drawing.Size(591, 150);
            this.dataGridViewEstudantes.TabIndex = 60;
            // 
            // TextBoxNotaTrabalho
            // 
            this.TextBoxNotaTrabalho.Location = new System.Drawing.Point(203, 115);
            this.TextBoxNotaTrabalho.Name = "TextBoxNotaTrabalho";
            this.TextBoxNotaTrabalho.Size = new System.Drawing.Size(41, 20);
            this.TextBoxNotaTrabalho.TabIndex = 55;
            // 
            // TextBoxNotaTeste
            // 
            this.TextBoxNotaTeste.Location = new System.Drawing.Point(203, 84);
            this.TextBoxNotaTeste.Name = "TextBoxNotaTeste";
            this.TextBoxNotaTeste.Size = new System.Drawing.Size(41, 20);
            this.TextBoxNotaTeste.TabIndex = 54;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(203, 53);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(351, 20);
            this.TextBoxNome.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nota trabalho:";
            // 
            // TextBoxNumero
            // 
            this.TextBoxNumero.Location = new System.Drawing.Point(203, 22);
            this.TextBoxNumero.Name = "TextBoxNumero";
            this.TextBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumero.TabIndex = 52;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(104, 84);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 16);
            this.Label5.TabIndex = 64;
            this.Label5.Text = "Nota teste:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(102, 53);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "Nome:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(102, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 16);
            this.Label3.TabIndex = 62;
            this.Label3.Text = "Numero:";
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlterar.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlterar.Location = new System.Drawing.Point(226, 155);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(110, 30);
            this.ButtonAlterar.TabIndex = 57;
            this.ButtonAlterar.Text = "Alterar registo";
            this.ButtonAlterar.UseVisualStyleBackColor = false;
            this.ButtonAlterar.Click += new System.EventHandler(this.ButtonAlterar_Click);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovo.ForeColor = System.Drawing.Color.Black;
            this.ButtonNovo.Location = new System.Drawing.Point(589, 155);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(110, 30);
            this.ButtonNovo.TabIndex = 59;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.ForeColor = System.Drawing.Color.Black;
            this.ButtonEliminar.Location = new System.Drawing.Point(349, 155);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(110, 30);
            this.ButtonEliminar.TabIndex = 58;
            this.ButtonEliminar.Text = "Eliminar registo";
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            // 
            // ButtonInserir
            // 
            this.ButtonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInserir.ForeColor = System.Drawing.Color.Black;
            this.ButtonInserir.Location = new System.Drawing.Point(108, 155);
            this.ButtonInserir.Name = "ButtonInserir";
            this.ButtonInserir.Size = new System.Drawing.Size(110, 30);
            this.ButtonInserir.TabIndex = 56;
            this.ButtonInserir.Text = "Inserir registo";
            this.ButtonInserir.UseVisualStyleBackColor = false;
            this.ButtonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);
            // 
            // FormNotas_ClassBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormNotas_ClassBD";
            this.Text = "FormNotas_ClassBD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonSair;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.DataGridView dataGridViewEstudantes;
        internal System.Windows.Forms.TextBox TextBoxNotaTrabalho;
        internal System.Windows.Forms.TextBox TextBoxNotaTeste;
        internal System.Windows.Forms.TextBox TextBoxNome;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox TextBoxNumero;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ButtonAlterar;
        internal System.Windows.Forms.Button ButtonNovo;
        internal System.Windows.Forms.Button ButtonEliminar;
        internal System.Windows.Forms.Button ButtonInserir;
    }
}