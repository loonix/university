namespace Exame2019
{
    partial class UserControlData
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
            this.texto1Label = new System.Windows.Forms.Label();
            this.texto2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texto1Label
            // 
            this.texto1Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.texto1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.texto1Label.Location = new System.Drawing.Point(0, 0);
            this.texto1Label.Name = "texto1Label";
            this.texto1Label.Size = new System.Drawing.Size(114, 17);
            this.texto1Label.TabIndex = 0;
            this.texto1Label.Text = "label1";
            // 
            // texto2Label
            // 
            this.texto2Label.BackColor = System.Drawing.Color.Aqua;
            this.texto2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.texto2Label.Location = new System.Drawing.Point(111, 0);
            this.texto2Label.Name = "texto2Label";
            this.texto2Label.Size = new System.Drawing.Size(111, 17);
            this.texto2Label.TabIndex = 1;
            this.texto2Label.Text = "label2";
            // 
            // UserControlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.texto2Label);
            this.Controls.Add(this.texto1Label);
            this.Name = "UserControlData";
            this.Size = new System.Drawing.Size(222, 17);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label texto1Label;
        private System.Windows.Forms.Label texto2Label;
    }
}
