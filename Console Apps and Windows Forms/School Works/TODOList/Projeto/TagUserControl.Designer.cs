namespace Notas
{
    partial class TagUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartoesCheckBox = new System.Windows.Forms.CheckBox();
            this.pagamentosCheckBox = new System.Windows.Forms.CheckBox();
            this.comprasCheckBox = new System.Windows.Forms.CheckBox();
            this.escolaCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartoesCheckBox);
            this.panel1.Controls.Add(this.pagamentosCheckBox);
            this.panel1.Controls.Add(this.comprasCheckBox);
            this.panel1.Controls.Add(this.escolaCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 50);
            this.panel1.TabIndex = 0;
            // 
            // cartoesCheckBox
            // 
            this.cartoesCheckBox.AutoSize = true;
            this.cartoesCheckBox.Location = new System.Drawing.Point(97, 27);
            this.cartoesCheckBox.Name = "cartoesCheckBox";
            this.cartoesCheckBox.Size = new System.Drawing.Size(62, 17);
            this.cartoesCheckBox.TabIndex = 3;
            this.cartoesCheckBox.Text = "Cartoes";
            this.cartoesCheckBox.UseVisualStyleBackColor = true;
            this.cartoesCheckBox.Click += new System.EventHandler(this.tagCheckBox_Click);
            // 
            // pagamentosCheckBox
            // 
            this.pagamentosCheckBox.AutoSize = true;
            this.pagamentosCheckBox.Location = new System.Drawing.Point(97, 4);
            this.pagamentosCheckBox.Name = "pagamentosCheckBox";
            this.pagamentosCheckBox.Size = new System.Drawing.Size(85, 17);
            this.pagamentosCheckBox.TabIndex = 2;
            this.pagamentosCheckBox.Text = "Pagamentos";
            this.pagamentosCheckBox.UseVisualStyleBackColor = true;
            this.pagamentosCheckBox.Click += new System.EventHandler(this.tagCheckBox_Click);
            // 
            // comprasCheckBox
            // 
            this.comprasCheckBox.AutoSize = true;
            this.comprasCheckBox.Location = new System.Drawing.Point(6, 27);
            this.comprasCheckBox.Name = "comprasCheckBox";
            this.comprasCheckBox.Size = new System.Drawing.Size(67, 17);
            this.comprasCheckBox.TabIndex = 1;
            this.comprasCheckBox.Text = "Compras";
            this.comprasCheckBox.UseVisualStyleBackColor = true;
            this.comprasCheckBox.Click += new System.EventHandler(this.tagCheckBox_Click);
            // 
            // escolaCheckBox
            // 
            this.escolaCheckBox.AutoSize = true;
            this.escolaCheckBox.Location = new System.Drawing.Point(6, 4);
            this.escolaCheckBox.Name = "escolaCheckBox";
            this.escolaCheckBox.Size = new System.Drawing.Size(58, 17);
            this.escolaCheckBox.TabIndex = 0;
            this.escolaCheckBox.Text = "Escola";
            this.escolaCheckBox.UseVisualStyleBackColor = true;
            this.escolaCheckBox.Click += new System.EventHandler(this.tagCheckBox_Click);
            // 
            // TagUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TagUserControl";
            this.Size = new System.Drawing.Size(192, 50);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox pagamentosCheckBox;
        private System.Windows.Forms.CheckBox comprasCheckBox;
        private System.Windows.Forms.CheckBox escolaCheckBox;
        private System.Windows.Forms.CheckBox cartoesCheckBox;
    }
}
