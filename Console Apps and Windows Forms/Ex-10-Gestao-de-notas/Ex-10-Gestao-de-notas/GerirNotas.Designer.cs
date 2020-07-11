namespace Ex_10_Gestao_de_notas
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNotaTrabalho = new System.Windows.Forms.TextBox();
            this.TextBoxNotaTeste = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxNumero = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasDBDataSet = new Ex_10_Gestao_de_notas.NotasDBDataSet();
            this.estudantesTableAdapter = new Ex_10_Gestao_de_notas.NotasDBDataSetTableAdapters.EstudantesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaTesteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaTrabalhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(662, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(285, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Eliminar Registo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(145, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Alterar Registo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Inserir Registo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nota Trabalho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nota Teste:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero:";
            // 
            // TextBoxNotaTrabalho
            // 
            this.TextBoxNotaTrabalho.Location = new System.Drawing.Point(121, 131);
            this.TextBoxNotaTrabalho.Name = "TextBoxNotaTrabalho";
            this.TextBoxNotaTrabalho.Size = new System.Drawing.Size(138, 20);
            this.TextBoxNotaTrabalho.TabIndex = 15;
            // 
            // TextBoxNotaTeste
            // 
            this.TextBoxNotaTeste.Location = new System.Drawing.Point(121, 94);
            this.TextBoxNotaTeste.Name = "TextBoxNotaTeste";
            this.TextBoxNotaTeste.Size = new System.Drawing.Size(138, 20);
            this.TextBoxNotaTeste.TabIndex = 14;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(121, 54);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(302, 20);
            this.TextBoxNome.TabIndex = 13;
            // 
            // TextBoxNumero
            // 
            this.TextBoxNumero.Location = new System.Drawing.Point(121, 18);
            this.TextBoxNumero.Name = "TextBoxNumero";
            this.TextBoxNumero.Size = new System.Drawing.Size(138, 20);
            this.TextBoxNumero.TabIndex = 12;
            this.TextBoxNumero.Leave += new System.EventHandler(this.TextBoxNumero_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.notaTesteDataGridViewTextBoxColumn,
            this.notaTrabalhoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estudantesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 226);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // estudantesBindingSource
            // 
            this.estudantesBindingSource.DataMember = "Estudantes";
            this.estudantesBindingSource.DataSource = this.notasDBDataSet;
            // 
            // notasDBDataSet
            // 
            this.notasDBDataSet.DataSetName = "NotasDBDataSet";
            this.notasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudantesTableAdapter
            // 
            this.estudantesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // notaTesteDataGridViewTextBoxColumn
            // 
            this.notaTesteDataGridViewTextBoxColumn.DataPropertyName = "NotaTeste";
            this.notaTesteDataGridViewTextBoxColumn.HeaderText = "NotaTeste";
            this.notaTesteDataGridViewTextBoxColumn.Name = "notaTesteDataGridViewTextBoxColumn";
            // 
            // notaTrabalhoDataGridViewTextBoxColumn
            // 
            this.notaTrabalhoDataGridViewTextBoxColumn.DataPropertyName = "NotaTrabalho";
            this.notaTrabalhoDataGridViewTextBoxColumn.HeaderText = "NotaTrabalho";
            this.notaTrabalhoDataGridViewTextBoxColumn.Name = "notaTrabalhoDataGridViewTextBoxColumn";
            // 
            // GerirNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNotaTrabalho);
            this.Controls.Add(this.TextBoxNotaTeste);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.TextBoxNumero);
            this.Name = "GerirNotas";
            this.Text = "GerirNotas";
            this.Load += new System.EventHandler(this.GerirNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNotaTrabalho;
        private System.Windows.Forms.TextBox TextBoxNotaTeste;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxNumero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotasDBDataSet notasDBDataSet;
        private System.Windows.Forms.BindingSource estudantesBindingSource;
        private NotasDBDataSetTableAdapters.EstudantesTableAdapter estudantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaTesteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaTrabalhoDataGridViewTextBoxColumn;
    }
}