using System;
using System.Windows.Forms;

namespace MultiScreenTEST
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
            // ActiveForm can't be null because HomeForm is always visible
            var screenSize = Screen.FromControl(ActiveForm).Bounds;
            Width = screenSize.Width;
            Height = screenSize.Height;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData != Keys.Escape)
                return false;

            Close();
            return true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}