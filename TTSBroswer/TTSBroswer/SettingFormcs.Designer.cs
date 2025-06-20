namespace TTSBroswer
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox darkmodecheckBox;
        private System.Windows.Forms.Button okButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.darkmodecheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // darkmodecheckBox
            // 
            this.darkmodecheckBox.AutoSize = true;
            this.darkmodecheckBox.Location = new System.Drawing.Point(253, 109);
            this.darkmodecheckBox.Name = "darkmodecheckBox";
            this.darkmodecheckBox.Size = new System.Drawing.Size(105, 24);
            this.darkmodecheckBox.TabIndex = 0;
            this.darkmodecheckBox.Text = "Dark Mode";
            this.darkmodecheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(628, 401);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(160, 37);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.darkmodecheckBox);
            this.Icon = (System.Drawing.Icon?)resources.GetObject("$this.Icon");
            this.Name = "SettingsForm";
            this.Text = "TTSBroswer Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
