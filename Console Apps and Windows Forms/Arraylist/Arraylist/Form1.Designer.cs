namespace Arraylist
{
    partial class Form1
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
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adicionaRegBtn = new System.Windows.Forms.Button();
            this.atualizaListaBtn = new System.Windows.Forms.Button();
            this.estudanteArrayList = new System.Windows.Forms.ListBox();
            this.estudanteList = new System.Windows.Forms.ListBox();
            this.labelErro1 = new System.Windows.Forms.Label();
            this.labelErro2 = new System.Windows.Forms.Label();
            this.labelErro3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(90, 22);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(125, 20);
            this.textBoxNumero.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(90, 63);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(125, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(90, 104);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(125, 20);
            this.textBoxNota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estudante no ArrayList";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estudante no List";
            // 
            // adicionaRegBtn
            // 
            this.adicionaRegBtn.Location = new System.Drawing.Point(32, 153);
            this.adicionaRegBtn.Name = "adicionaRegBtn";
            this.adicionaRegBtn.Size = new System.Drawing.Size(183, 38);
            this.adicionaRegBtn.TabIndex = 8;
            this.adicionaRegBtn.Text = "Adiciona registo ao Arraylist e a List";
            this.adicionaRegBtn.UseVisualStyleBackColor = true;
            this.adicionaRegBtn.Click += new System.EventHandler(this.adicionaRegBtn_Click);
            // 
            // atualizaListaBtn
            // 
            this.atualizaListaBtn.Location = new System.Drawing.Point(255, 12);
            this.atualizaListaBtn.Name = "atualizaListaBtn";
            this.atualizaListaBtn.Size = new System.Drawing.Size(370, 43);
            this.atualizaListaBtn.TabIndex = 9;
            this.atualizaListaBtn.Text = "Atualiza Lista";
            this.atualizaListaBtn.UseVisualStyleBackColor = true;
            this.atualizaListaBtn.Click += new System.EventHandler(this.atualizaListaBtn_Click);
            // 
            // estudanteArrayList
            // 
            this.estudanteArrayList.FormattingEnabled = true;
            this.estudanteArrayList.Location = new System.Drawing.Point(255, 85);
            this.estudanteArrayList.Name = "estudanteArrayList";
            this.estudanteArrayList.Size = new System.Drawing.Size(183, 121);
            this.estudanteArrayList.TabIndex = 10;
            // 
            // estudanteList
            // 
            this.estudanteList.FormattingEnabled = true;
            this.estudanteList.Location = new System.Drawing.Point(442, 85);
            this.estudanteList.Name = "estudanteList";
            this.estudanteList.Size = new System.Drawing.Size(183, 121);
            this.estudanteList.TabIndex = 11;
            // 
            // labelErro1
            // 
            this.labelErro1.AutoSize = true;
            this.labelErro1.ForeColor = System.Drawing.Color.Red;
            this.labelErro1.Location = new System.Drawing.Point(87, 44);
            this.labelErro1.Name = "labelErro1";
            this.labelErro1.Size = new System.Drawing.Size(84, 13);
            this.labelErro1.TabIndex = 12;
            this.labelErro1.Text = "Numero Invalido";
            this.labelErro1.Visible = false;
            // 
            // labelErro2
            // 
            this.labelErro2.AutoSize = true;
            this.labelErro2.ForeColor = System.Drawing.Color.Red;
            this.labelErro2.Location = new System.Drawing.Point(87, 86);
            this.labelErro2.Name = "labelErro2";
            this.labelErro2.Size = new System.Drawing.Size(75, 13);
            this.labelErro2.TabIndex = 13;
            this.labelErro2.Text = "Nome Invalido";
            this.labelErro2.Visible = false;
            // 
            // labelErro3
            // 
            this.labelErro3.AutoSize = true;
            this.labelErro3.ForeColor = System.Drawing.Color.Red;
            this.labelErro3.Location = new System.Drawing.Point(87, 127);
            this.labelErro3.Name = "labelErro3";
            this.labelErro3.Size = new System.Drawing.Size(70, 13);
            this.labelErro3.TabIndex = 14;
            this.labelErro3.Text = "Nota Invalido";
            this.labelErro3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 218);
            this.Controls.Add(this.labelErro3);
            this.Controls.Add(this.labelErro2);
            this.Controls.Add(this.labelErro1);
            this.Controls.Add(this.estudanteList);
            this.Controls.Add(this.estudanteArrayList);
            this.Controls.Add(this.atualizaListaBtn);
            this.Controls.Add(this.adicionaRegBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNumero);
            this.Name = "Form1";
            this.Text = "Arraylist e list com Struct";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adicionaRegBtn;
        private System.Windows.Forms.Button atualizaListaBtn;
        private System.Windows.Forms.ListBox estudanteArrayList;
        private System.Windows.Forms.ListBox estudanteList;
        private System.Windows.Forms.Label labelErro1;
        private System.Windows.Forms.Label labelErro2;
        private System.Windows.Forms.Label labelErro3;
    }
}

