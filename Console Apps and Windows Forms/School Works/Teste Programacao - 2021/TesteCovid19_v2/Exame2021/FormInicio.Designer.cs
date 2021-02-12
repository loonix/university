namespace Exame2019
{
    partial class FormInicio
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
            this.covidButton = new System.Windows.Forms.Button();
            this.userControlButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.testarBDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // covidButton
            // 
            this.covidButton.Location = new System.Drawing.Point(22, 12);
            this.covidButton.Name = "covidButton";
            this.covidButton.Size = new System.Drawing.Size(102, 29);
            this.covidButton.TabIndex = 0;
            this.covidButton.Text = "Covid";
            this.covidButton.UseVisualStyleBackColor = true;
            this.covidButton.Click += new System.EventHandler(this.covidButton_Click);
            // 
            // userControlButton
            // 
            this.userControlButton.Location = new System.Drawing.Point(22, 47);
            this.userControlButton.Name = "userControlButton";
            this.userControlButton.Size = new System.Drawing.Size(102, 29);
            this.userControlButton.TabIndex = 1;
            this.userControlButton.Text = "User Control";
            this.userControlButton.UseVisualStyleBackColor = true;
            this.userControlButton.Click += new System.EventHandler(this.userControlButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(320, 47);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(102, 29);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // testarBDButton
            // 
            this.testarBDButton.Location = new System.Drawing.Point(320, 12);
            this.testarBDButton.Name = "testarBDButton";
            this.testarBDButton.Size = new System.Drawing.Size(102, 29);
            this.testarBDButton.TabIndex = 2;
            this.testarBDButton.Text = "TestarBD";
            this.testarBDButton.UseVisualStyleBackColor = true;
            this.testarBDButton.Click += new System.EventHandler(this.testarBDButton_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 126);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.testarBDButton);
            this.Controls.Add(this.userControlButton);
            this.Controls.Add(this.covidButton);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button covidButton;
        private System.Windows.Forms.Button userControlButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button testarBDButton;
    }
}