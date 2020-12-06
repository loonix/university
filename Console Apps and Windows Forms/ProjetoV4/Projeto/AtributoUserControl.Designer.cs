namespace ExemploProjeto
{
    partial class AtributoUserControl
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
            this.atributoPanel = new System.Windows.Forms.Panel();
            this.comFinanciamentoCheckBox = new System.Windows.Forms.CheckBox();
            this.finalizadoCheckBox = new System.Windows.Forms.CheckBox();
            this.pagoCheckBox = new System.Windows.Forms.CheckBox();
            this.atributoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // atributoPanel
            // 
            this.atributoPanel.Controls.Add(this.comFinanciamentoCheckBox);
            this.atributoPanel.Controls.Add(this.finalizadoCheckBox);
            this.atributoPanel.Controls.Add(this.pagoCheckBox);
            this.atributoPanel.Location = new System.Drawing.Point(3, 3);
            this.atributoPanel.Name = "atributoPanel";
            this.atributoPanel.Size = new System.Drawing.Size(133, 79);
            this.atributoPanel.TabIndex = 21;
            // 
            // comFinanciamentoCheckBox
            // 
            this.comFinanciamentoCheckBox.AutoSize = true;
            this.comFinanciamentoCheckBox.Location = new System.Drawing.Point(3, 52);
            this.comFinanciamentoCheckBox.Name = "comFinanciamentoCheckBox";
            this.comFinanciamentoCheckBox.Size = new System.Drawing.Size(116, 17);
            this.comFinanciamentoCheckBox.TabIndex = 2;
            this.comFinanciamentoCheckBox.Text = "Com financiamento";
            this.comFinanciamentoCheckBox.UseVisualStyleBackColor = true;
            this.comFinanciamentoCheckBox.Click += new System.EventHandler(this.atributoCheckBox_Click);
            // 
            // finalizadoCheckBox
            // 
            this.finalizadoCheckBox.AutoSize = true;
            this.finalizadoCheckBox.Location = new System.Drawing.Point(3, 29);
            this.finalizadoCheckBox.Name = "finalizadoCheckBox";
            this.finalizadoCheckBox.Size = new System.Drawing.Size(73, 17);
            this.finalizadoCheckBox.TabIndex = 1;
            this.finalizadoCheckBox.Text = "Finalizado";
            this.finalizadoCheckBox.UseVisualStyleBackColor = true;
            this.finalizadoCheckBox.Click += new System.EventHandler(this.atributoCheckBox_Click);
            // 
            // pagoCheckBox
            // 
            this.pagoCheckBox.AutoSize = true;
            this.pagoCheckBox.Location = new System.Drawing.Point(3, 6);
            this.pagoCheckBox.Name = "pagoCheckBox";
            this.pagoCheckBox.Size = new System.Drawing.Size(51, 17);
            this.pagoCheckBox.TabIndex = 0;
            this.pagoCheckBox.Text = "Pago";
            this.pagoCheckBox.UseVisualStyleBackColor = true;
            this.pagoCheckBox.Click += new System.EventHandler(this.atributoCheckBox_Click);
            // 
            // AtributoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.atributoPanel);
            this.Name = "AtributoUserControl";
            this.Size = new System.Drawing.Size(139, 87);
            this.atributoPanel.ResumeLayout(false);
            this.atributoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel atributoPanel;
        private System.Windows.Forms.CheckBox comFinanciamentoCheckBox;
        private System.Windows.Forms.CheckBox finalizadoCheckBox;
        private System.Windows.Forms.CheckBox pagoCheckBox;
    }
}
