using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Brain_Pathology
{
    public partial class MoreInfoView : Form
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

        // ##################################| Variables
        private bool dragging = false; // "dragging" is used to track whether an item is currently being dragged on the screen
        private Point dragStart;       // "dragStart" stores the starting position of the drag operation

        // ##################################| Init
        public MoreInfoView()
        {
            // Initialize the form and its components
            InitializeComponent();

            // Create a rounded region for the form's edges using Windows API function CreateRoundRectRgn
            // This gives the form a rounded corner effect with a radius of 25 pixels
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //patientDetection = new PatientDetection();
        }

        // 1.#########| Move the Form
        private void AppBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Start dragging the form
            dragging = true;
            dragStart = new Point(e.X, e.Y);
        }

        private void AppBar_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the form if it's being dragged
            if (dragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - dragStart.X;
                newLocation.Y += e.Y - dragStart.Y;
                this.Location = newLocation;
            }
        }

        private void AppBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging the form
            dragging = false;
        }

        private void MoreInfoView_Load(object sender, EventArgs e)
        {
            showImage(url: FlaskServer.patientDetection.ImageInfo.ImageUrl);

            String title = FlaskServer.patientDetection.Expectation.IsBrainDisease;
            String subTitle = "";
            Color color = Color.Green;

            if (title == BrainDisease.Positive.ToString())
            {
                subTitle = "I regret to inform you that the results of your recent medical tests indicate that you have a brain tumor. I understand that this news may be difficult to hear, and please know that I am here to support you through this difficult time.\r\n\r\nIt's important to understand that a brain tumor is a serious condition that requires immediate medical attention. However, there are various treatment options available, and the earlier we begin treatment, the better your chances of a positive outcome.";
                color = Color.Red;
            }
            else
            {
                subTitle = "I am pleased to inform you that the results of your recent medical tests indicate that you do not have a brain tumor. This is excellent news, and you can breathe a sigh of relief.";
            }

            titleLb.ForeColor = color;
            titleLb.Text = title;
            descLb.Text = subTitle;
        }



        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showImage(string url = "")
        {
            Bitmap image;
            if (url.Length != 0)
            {
                // show the image from url
                HttpWebRequest? httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = httpWebReponse.GetResponseStream();
                // Load the image into a Bitmap object
                image = new Bitmap(stream);

                imageBox.Image = image;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageBox_Click(object sender, EventArgs e)
        {
            String url = FlaskServer.patientDetection.ImageInfo.ImageUrl;
            Clipboard.SetText(url);

            try
            {

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                };

                Process.Start(psi);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
