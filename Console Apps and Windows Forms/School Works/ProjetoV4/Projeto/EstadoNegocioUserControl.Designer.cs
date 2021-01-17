namespace ExemploProjeto
{
    partial class EstadoNegocioUserControl
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
            this.EstadoNegociopanel = new System.Windows.Forms.Panel();
            this.proposalRadioButton = new System.Windows.Forms.RadioButton();
            this.closePendRadioButton = new System.Windows.Forms.RadioButton();
            this.subCasePendRadioButton = new System.Windows.Forms.RadioButton();
            this.informationPendradioButton = new System.Windows.Forms.RadioButton();
            this.onHoldRadioButton = new System.Windows.Forms.RadioButton();
            this.inProgressRadioButton = new System.Windows.Forms.RadioButton();
            this.EstadoNegociopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadoNegociopanel
            // 
            this.EstadoNegociopanel.Controls.Add(this.proposalRadioButton);
            this.EstadoNegociopanel.Controls.Add(this.closePendRadioButton);
            this.EstadoNegociopanel.Controls.Add(this.subCasePendRadioButton);
            this.EstadoNegociopanel.Controls.Add(this.informationPendradioButton);
            this.EstadoNegociopanel.Controls.Add(this.onHoldRadioButton);
            this.EstadoNegociopanel.Controls.Add(this.inProgressRadioButton);
            this.EstadoNegociopanel.Location = new System.Drawing.Point(3, 3);
            this.EstadoNegociopanel.Name = "EstadoNegociopanel";
            this.EstadoNegociopanel.Size = new System.Drawing.Size(126, 140);
            this.EstadoNegociopanel.TabIndex = 38;
            // 
            // proposalRadioButton
            // 
            this.proposalRadioButton.AutoSize = true;
            this.proposalRadioButton.Location = new System.Drawing.Point(20, 116);
            this.proposalRadioButton.Name = "proposalRadioButton";
            this.proposalRadioButton.Size = new System.Drawing.Size(66, 17);
            this.proposalRadioButton.TabIndex = 38;
            this.proposalRadioButton.TabStop = true;
            this.proposalRadioButton.Text = "Proposal";
            this.proposalRadioButton.UseVisualStyleBackColor = true;
            // 
            // closePendRadioButton
            // 
            this.closePendRadioButton.AutoSize = true;
            this.closePendRadioButton.Location = new System.Drawing.Point(19, 95);
            this.closePendRadioButton.Name = "closePendRadioButton";
            this.closePendRadioButton.Size = new System.Drawing.Size(79, 17);
            this.closePendRadioButton.TabIndex = 39;
            this.closePendRadioButton.TabStop = true;
            this.closePendRadioButton.Text = "Close Pend";
            this.closePendRadioButton.UseVisualStyleBackColor = true;
            // 
            // subCasePendRadioButton
            // 
            this.subCasePendRadioButton.AutoSize = true;
            this.subCasePendRadioButton.Location = new System.Drawing.Point(19, 72);
            this.subCasePendRadioButton.Name = "subCasePendRadioButton";
            this.subCasePendRadioButton.Size = new System.Drawing.Size(96, 17);
            this.subCasePendRadioButton.TabIndex = 40;
            this.subCasePendRadioButton.TabStop = true;
            this.subCasePendRadioButton.Text = "SubCase Pend";
            this.subCasePendRadioButton.UseVisualStyleBackColor = true;
            // 
            // informationPendradioButton
            // 
            this.informationPendradioButton.AutoSize = true;
            this.informationPendradioButton.Location = new System.Drawing.Point(19, 49);
            this.informationPendradioButton.Name = "informationPendradioButton";
            this.informationPendradioButton.Size = new System.Drawing.Size(105, 17);
            this.informationPendradioButton.TabIndex = 41;
            this.informationPendradioButton.TabStop = true;
            this.informationPendradioButton.Text = "Information Pend";
            this.informationPendradioButton.UseVisualStyleBackColor = true;
            // 
            // onHoldRadioButton
            // 
            this.onHoldRadioButton.AutoSize = true;
            this.onHoldRadioButton.Location = new System.Drawing.Point(19, 26);
            this.onHoldRadioButton.Name = "onHoldRadioButton";
            this.onHoldRadioButton.Size = new System.Drawing.Size(64, 17);
            this.onHoldRadioButton.TabIndex = 42;
            this.onHoldRadioButton.TabStop = true;
            this.onHoldRadioButton.Text = "On Hold";
            this.onHoldRadioButton.UseVisualStyleBackColor = true;
            // 
            // inProgressRadioButton
            // 
            this.inProgressRadioButton.AutoSize = true;
            this.inProgressRadioButton.Location = new System.Drawing.Point(20, 3);
            this.inProgressRadioButton.Name = "inProgressRadioButton";
            this.inProgressRadioButton.Size = new System.Drawing.Size(78, 17);
            this.inProgressRadioButton.TabIndex = 43;
            this.inProgressRadioButton.TabStop = true;
            this.inProgressRadioButton.Text = "In Progress";
            this.inProgressRadioButton.UseVisualStyleBackColor = true;
            // 
            // EstadoNegocioUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EstadoNegociopanel);
            this.Name = "EstadoNegocioUserControl";
            this.Size = new System.Drawing.Size(129, 146);
            this.EstadoNegociopanel.ResumeLayout(false);
            this.EstadoNegociopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EstadoNegociopanel;
        private System.Windows.Forms.RadioButton proposalRadioButton;
        private System.Windows.Forms.RadioButton closePendRadioButton;
        private System.Windows.Forms.RadioButton subCasePendRadioButton;
        private System.Windows.Forms.RadioButton informationPendradioButton;
        private System.Windows.Forms.RadioButton onHoldRadioButton;
        private System.Windows.Forms.RadioButton inProgressRadioButton;
    }
}
