using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Brain_Pathology
{
    public partial class SplashView : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public SplashView()
        {
            // Initialize the form and its components
            InitializeComponent();

            // Create a rounded region for the form's edges using Windows API function CreateRoundRectRgn
            // This gives the form a rounded corner effect with a radius of 25 pixels
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Set the initial value of the progress bar to 0%
            progressBar.Value = 0;

        }

        /**
         * This method is called every time the timer1 interval is elapsed. It updates the value and text of a progress bar control.
         * If the progress bar value reaches 100%, it disables the timer, updates the progress bar text to "Done!", hides the current form, creates a new instance of the AppView form, shows it as a dialog, and closes the current form.
         *
         * @param sender The object that raised the event.
         * @param e The event arguments.
         * @return void
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Updates the value and text of a progress bar control.
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == 100)
            {
                // disables the timer
                timer1.Enabled = false;
                progressBar.Text = "Done!";

                // Hide the Splash View
                this.Hide();
                // Creates a new instance of the AppView form
                Form appView = new AppView();
                // Show the form as a dialog and wait for it to be closed
                appView.ShowDialog();
                // Once the dialog is closed, close the Splash View form
                this.Close();
            }
        }
    }
}
