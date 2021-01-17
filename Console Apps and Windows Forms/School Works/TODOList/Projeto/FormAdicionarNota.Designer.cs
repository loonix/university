namespace Notas
{
    partial class FormAdicionarNota
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
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.expiraEmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.conteudoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.destaqueCheckBox = new System.Windows.Forms.CheckBox();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataCriacaoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.notaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.limparBtn = new System.Windows.Forms.Button();
            this.tagUserControl1 = new Notas.TagUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.notaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(12, 29);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(425, 20);
            this.tituloTextBox.TabIndex = 1;
            // 
            // expiraEmDatePicker
            // 
            this.expiraEmDatePicker.Location = new System.Drawing.Point(454, 29);
            this.expiraEmDatePicker.Name = "expiraEmDatePicker";
            this.expiraEmDatePicker.Size = new System.Drawing.Size(136, 20);
            this.expiraEmDatePicker.TabIndex = 2;
            // 
            // conteudoRichTextBox
            // 
            this.conteudoRichTextBox.Location = new System.Drawing.Point(12, 73);
            this.conteudoRichTextBox.Name = "conteudoRichTextBox";
            this.conteudoRichTextBox.Size = new System.Drawing.Size(578, 108);
            this.conteudoRichTextBox.TabIndex = 4;
            this.conteudoRichTextBox.Text = "";
            // 
            // destaqueCheckBox
            // 
            this.destaqueCheckBox.AutoSize = true;
            this.destaqueCheckBox.Location = new System.Drawing.Point(492, 55);
            this.destaqueCheckBox.Name = "destaqueCheckBox";
            this.destaqueCheckBox.Size = new System.Drawing.Size(95, 17);
            this.destaqueCheckBox.TabIndex = 3;
            this.destaqueCheckBox.Text = "Destacar Nota";
            this.destaqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.adicionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.adicionarBtn.Location = new System.Drawing.Point(502, 220);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(106, 45);
            this.adicionarBtn.TabIndex = 6;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = false;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expira em:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Conteudo:";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarBtn.BackColor = System.Drawing.Color.SlateGray;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelarBtn.Location = new System.Drawing.Point(278, 220);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(106, 45);
            this.cancelarBtn.TabIndex = 8;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tags:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(76, 185);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 14;
            this.idTextBox.Visible = false;
            // 
            // dataCriacaoDatePicker
            // 
            this.dataCriacaoDatePicker.Location = new System.Drawing.Point(182, 185);
            this.dataCriacaoDatePicker.Name = "dataCriacaoDatePicker";
            this.dataCriacaoDatePicker.Size = new System.Drawing.Size(136, 20);
            this.dataCriacaoDatePicker.TabIndex = 15;
            this.dataCriacaoDatePicker.Visible = false;
            // 
            // notaErrorProvider
            // 
            this.notaErrorProvider.ContainerControl = this;
            // 
            // limparBtn
            // 
            this.limparBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.limparBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.limparBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.ForeColor = System.Drawing.Color.Transparent;
            this.limparBtn.Location = new System.Drawing.Point(390, 220);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(106, 45);
            this.limparBtn.TabIndex = 7;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // tagUserControl1
            // 
            this.tagUserControl1.Location = new System.Drawing.Point(12, 204);
            this.tagUserControl1.Name = "tagUserControl1";
            this.tagUserControl1.Size = new System.Drawing.Size(230, 48);
            this.tagUserControl1.TabIndex = 5;
            this.tagUserControl1.Tags = CamadaNegocio.TagsEnum.NaoDefinido;
            // 
            // FormAdicionarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 274);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.dataCriacaoDatePicker);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.tagUserControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.destaqueCheckBox);
            this.Controls.Add(this.conteudoRichTextBox);
            this.Controls.Add(this.expiraEmDatePicker);
            this.Controls.Add(this.tituloTextBox);
            this.Name = "FormAdicionarNota";
            this.Text = "Adicionar Nota";
            this.Load += new System.EventHandler(this.FormAdicionarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.DateTimePicker expiraEmDatePicker;
        private System.Windows.Forms.RichTextBox conteudoRichTextBox;
        private System.Windows.Forms.CheckBox destaqueCheckBox;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label label3;
        private TagUserControl tagUserControl1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dataCriacaoDatePicker;
        private System.Windows.Forms.ErrorProvider notaErrorProvider;
        private System.Windows.Forms.Button limparBtn;
    }
}