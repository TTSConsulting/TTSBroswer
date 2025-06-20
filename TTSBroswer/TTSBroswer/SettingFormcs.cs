using System;
using System.Drawing;
using System.Windows.Forms;
using TTSBroswer;

namespace TTSBroswer
{
    public partial class SettingsForm : Form
    {
        private Form1 mainForm;
        private SettingsForm settingsForm;
        private AboutForm aboutForm;

        public SettingsForm(Form1 parent)
        {
            InitializeComponent();
            mainForm = parent;
        }

        public void SettingsForm_Load(object sender, EventArgs e)
        {
            darkmodecheckBox.CheckedChanged += (s, ev) =>
            {
                ApplyDarkMode(darkmodecheckBox.Checked);
            };
        }


        public void ApplyDarkMode(bool enabled)
        {
            var bg = enabled ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            var fg = enabled ? Color.White : SystemColors.ControlText;

            this.BackColor = bg;
            ApplyThemeToControls(this.Controls, bg, fg);
            mainForm.isdark = enabled;
            mainForm.godarkmode();
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Color bg, Color fg)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.BackColor = bg;
                ctrl.ForeColor = fg;

                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl.Controls, bg, fg);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool darkModeEnabled = darkmodecheckBox.Checked;

            // Send the signal back to the main window  
            mainForm.ApplyDarkMode(darkModeEnabled);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
