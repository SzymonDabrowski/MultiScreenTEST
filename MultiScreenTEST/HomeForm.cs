using System;
using System.Linq;
using System.Windows.Forms;

namespace MultiScreenTEST
{
    public partial class HomeForm : Form
    {
        private ClockForm ClockForm;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void buttonRunClock_Click(object sender, EventArgs e)
        {
            var availableScreens = Screen.AllScreens;

            if (availableScreens.Length <= 1)
            {
                const string secondScreenNotFoundError =
                    "Can't find second screen. Check if monitor is plugged into your cumputer.";

                MessageBox.Show(secondScreenNotFoundError);
                return;
            }

            if (Application.OpenForms.OfType<ClockForm>().Any()) return;

            ClockForm = new ClockForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = availableScreens[1].Bounds.Location
            };

            ClockForm.Show();
        }
    }
}