namespace ExemploProjeto
{
    partial class GrauUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grauPanel = new System.Windows.Forms.Panel();
            this.naoDefinidoRadioButton = new System.Windows.Forms.RadioButton();
            this.elevadoRadioButton = new System.Windows.Forms.RadioButton();
            this.idealRadioButton = new System.Windows.Forms.RadioButton();
            this.simplesRadioButton = new System.Windows.Forms.RadioButton();
            this.grauPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grauPanel
            // 
            this.grauPanel.Controls.Add(this.naoDefinidoRadioButton);
            this.grauPanel.Controls.Add(this.elevadoRadioButton);
            this.grauPanel.Controls.Add(this.idealRadioButton);
            this.grauPanel.Controls.Add(this.simplesRadioButton);
            this.grauPanel.Location = new System.Drawing.Point(3, 3);
            this.grauPanel.Name = "grauPanel";
            this.grauPanel.Size = new System.Drawing.Size(115, 109);
            this.grauPanel.TabIndex = 20;
            // 
            // naoDefinidoRadioButton
            // 
            this.naoDefinidoRadioButton.AutoSize = true;
            this.naoDefinidoRadioButton.Checked = true;
            this.naoDefinidoRadioButton.Location = new System.Drawing.Point(15, 9);
            this.naoDefinidoRadioButton.Name = "naoDefinidoRadioButton";
            this.naoDefinidoRadioButton.Size = new System.Drawing.Size(85, 17);
            this.naoDefinidoRadioButton.TabIndex = 22;
            this.naoDefinidoRadioButton.TabStop = true;
            this.naoDefinidoRadioButton.Text = "Não definido";
            this.naoDefinidoRadioButton.UseVisualStyleBackColor = true;
            // 
            // elevadoRadioButton
            // 
            this.elevadoRadioButton.AutoSize = true;
            this.elevadoRadioButton.Location = new System.Drawing.Point(15, 78);
            this.elevadoRadioButton.Name = "elevadoRadioButton";
            this.elevadoRadioButton.Size = new System.Drawing.Size(64, 17);
            this.elevadoRadioButton.TabIndex = 21;
            this.elevadoRadioButton.Text = "Elevado";
            this.elevadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // idealRadioButton
            // 
            this.idealRadioButton.AutoSize = true;
            this.idealRadioButton.Location = new System.Drawing.Point(15, 55);
            this.idealRadioButton.Name = "idealRadioButton";
            this.idealRadioButton.Size = new System.Drawing.Size(48, 17);
            this.idealRadioButton.TabIndex = 20;
            this.idealRadioButton.Text = "Ideal";
            this.idealRadioButton.UseVisualStyleBackColor = true;
            this.idealRadioButton.Click += new System.EventHandler(this.idealRadioButton_Click);
            // 
            // simplesRadioButton
            // 
            this.simplesRadioButton.AutoSize = true;
            this.simplesRadioButton.Location = new System.Drawing.Point(15, 32);
            this.simplesRadioButton.Name = "simplesRadioButton";
            this.simplesRadioButton.Size = new System.Drawing.Size(61, 17);
            this.simplesRadioButton.TabIndex = 19;
            this.simplesRadioButton.Text = "Simples";
            this.simplesRadioButton.UseVisualStyleBackColor = true;
            // 
            // GrauUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.grauPanel);
            this.Name = "GrauUserControl";
            this.Size = new System.Drawing.Size(120, 114);
            this.grauPanel.ResumeLayout(false);
            this.grauPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grauPanel;
        private System.Windows.Forms.RadioButton naoDefinidoRadioButton;
        private System.Windows.Forms.RadioButton elevadoRadioButton;
        private System.Windows.Forms.RadioButton idealRadioButton;
        private System.Windows.Forms.RadioButton simplesRadioButton;
    }
}
