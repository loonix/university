namespace ExemploProjeto
{
    partial class FormComboio
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
            this.listaButton = new System.Windows.Forms.Button();
            this.dataFabricoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFabricoLabel = new System.Windows.Forms.Label();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.codigoComboioTextBox = new System.Windows.Forms.TextBox();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.codigoComboioLabel = new System.Windows.Forms.Label();
            this.numeroLugaresTextBox = new System.Windows.Forms.TextBox();
            this.numeroLugaresLabel = new System.Windows.Forms.Label();
            this.sairButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(230, 34);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(38, 20);
            this.listaButton.TabIndex = 19;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // dataFabricoDateTimePicker
            // 
            this.dataFabricoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFabricoDateTimePicker.Location = new System.Drawing.Point(125, 86);
            this.dataFabricoDateTimePicker.Name = "dataFabricoDateTimePicker";
            this.dataFabricoDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dataFabricoDateTimePicker.TabIndex = 18;
            // 
            // dataFabricoLabel
            // 
            this.dataFabricoLabel.AutoSize = true;
            this.dataFabricoLabel.Location = new System.Drawing.Point(24, 83);
            this.dataFabricoLabel.Name = "dataFabricoLabel";
            this.dataFabricoLabel.Size = new System.Drawing.Size(68, 13);
            this.dataFabricoLabel.TabIndex = 17;
            this.dataFabricoLabel.Text = "Data fabrico:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(124, 112);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(292, 20);
            this.modeloTextBox.TabIndex = 16;
            // 
            // codigoComboioTextBox
            // 
            this.codigoComboioTextBox.Location = new System.Drawing.Point(124, 34);
            this.codigoComboioTextBox.Name = "codigoComboioTextBox";
            this.codigoComboioTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoComboioTextBox.TabIndex = 15;
            this.codigoComboioTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigoComboioTextBox_KeyUp);
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(26, 112);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(45, 13);
            this.modeloLabel.TabIndex = 14;
            this.modeloLabel.Text = "Modelo:";
            // 
            // codigoComboioLabel
            // 
            this.codigoComboioLabel.AutoSize = true;
            this.codigoComboioLabel.Location = new System.Drawing.Point(26, 34);
            this.codigoComboioLabel.Name = "codigoComboioLabel";
            this.codigoComboioLabel.Size = new System.Drawing.Size(99, 13);
            this.codigoComboioLabel.TabIndex = 13;
            this.codigoComboioLabel.Text = "Codigo do Comboio";
            // 
            // numeroLugaresTextBox
            // 
            this.numeroLugaresTextBox.Location = new System.Drawing.Point(124, 60);
            this.numeroLugaresTextBox.Name = "numeroLugaresTextBox";
            this.numeroLugaresTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroLugaresTextBox.TabIndex = 21;
            // 
            // numeroLugaresLabel
            // 
            this.numeroLugaresLabel.AutoSize = true;
            this.numeroLugaresLabel.Location = new System.Drawing.Point(25, 60);
            this.numeroLugaresLabel.Name = "numeroLugaresLabel";
            this.numeroLugaresLabel.Size = new System.Drawing.Size(34, 13);
            this.numeroLugaresLabel.TabIndex = 20;
            this.numeroLugaresLabel.Text = "Valor:";
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(479, 102);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 25;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sair_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(479, 17);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 24;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novo_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(479, 73);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 23;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(480, 46);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 22;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // FormComboio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 155);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.numeroLugaresTextBox);
            this.Controls.Add(this.numeroLugaresLabel);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.dataFabricoDateTimePicker);
            this.Controls.Add(this.dataFabricoLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.codigoComboioTextBox);
            this.Controls.Add(this.modeloLabel);
            this.Controls.Add(this.codigoComboioLabel);
            this.Name = "FormComboio";
            this.Text = "FormComboio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.DateTimePicker dataFabricoDateTimePicker;
        private System.Windows.Forms.Label dataFabricoLabel;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox codigoComboioTextBox;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.Label codigoComboioLabel;
        private System.Windows.Forms.TextBox numeroLugaresTextBox;
        private System.Windows.Forms.Label numeroLugaresLabel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button gravarButton;
    }
}