namespace _04_USA
{
    partial class FormVisualiza
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
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAtualiza = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(804, 367);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome presidente";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ano Inicio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ano Fim";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Partido";
            this.Column4.Name = "Column4";
            // 
            // buttonAtualiza
            // 
            this.buttonAtualiza.Location = new System.Drawing.Point(12, 393);
            this.buttonAtualiza.Name = "buttonAtualiza";
            this.buttonAtualiza.Size = new System.Drawing.Size(102, 36);
            this.buttonAtualiza.TabIndex = 1;
            this.buttonAtualiza.Text = "Atualizar";
            this.buttonAtualiza.UseVisualStyleBackColor = true;
            this.buttonAtualiza.Click += new System.EventHandler(this.buttonAtualiza_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(686, 393);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(102, 36);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir Ficheiro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVisualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonAtualiza);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "FormVisualiza";
            this.Text = "FormVisualiza";
            this.Load += new System.EventHandler(this.FormVisualiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonAtualiza;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button button1;
    }
}