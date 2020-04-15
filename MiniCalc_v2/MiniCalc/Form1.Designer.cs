namespace MiniCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.Location = new System.Drawing.Point(392, 438);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(84, 35);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(103, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operador 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(253, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operador 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOp1.Location = new System.Drawing.Point(103, 141);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(128, 29);
            this.textBoxOp1.TabIndex = 0;
            this.textBoxOp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOp1.TextChanged += new System.EventHandler(this.textBoxOp1_TextChanged);
            this.textBoxOp1.Enter += new System.EventHandler(this.textBoxOp1_Enter);
            this.textBoxOp1.Leave += new System.EventHandler(this.textBoxOp1_Leave);
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOp2.Location = new System.Drawing.Point(253, 141);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(128, 29);
            this.textBoxOp2.TabIndex = 1;
            this.textBoxOp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOp2.TextChanged += new System.EventHandler(this.textBoxOp2_TextChanged);
            this.textBoxOp2.Enter += new System.EventHandler(this.textBoxOp2_Enter);
            this.textBoxOp2.Leave += new System.EventHandler(this.textBoxOp2_Leave);
            // 
            // buttonSoma
            // 
            this.buttonSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.ForeColor = System.Drawing.Color.White;
            this.buttonSoma.Location = new System.Drawing.Point(12, 254);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(115, 53);
            this.buttonSoma.TabIndex = 2;
            this.buttonSoma.Text = "Soma";
            this.buttonSoma.UseVisualStyleBackColor = false;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.Color.White;
            this.buttonSub.Location = new System.Drawing.Point(128, 254);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(115, 53);
            this.buttonSub.TabIndex = 3;
            this.buttonSub.Text = "Subtração";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMult.ForeColor = System.Drawing.Color.White;
            this.buttonMult.Location = new System.Drawing.Point(244, 254);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(115, 53);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "Multiplicação";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.Color.White;
            this.buttonDiv.Location = new System.Drawing.Point(360, 254);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(115, 53);
            this.buttonDiv.TabIndex = 5;
            this.buttonDiv.Text = "Divisão";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(181, 344);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(128, 29);
            this.textBoxResultado.TabIndex = 3;
            this.textBoxResultado.TabStop = false;
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMensagem
            // 
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.Location = new System.Drawing.Point(6, 376);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(482, 21);
            this.labelMensagem.TabIndex = 5;
            this.labelMensagem.Text = "Linha de mensagens";
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.Location = new System.Drawing.Point(12, 438);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(84, 35);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 485);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.textBoxOp2);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxOp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

