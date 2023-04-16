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
using Button = System.Windows.Forms.Button;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Security.Policy;

namespace Brain_Pathology
{
    public partial class AppView : Form
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

        delegate Task<PatientDetection> MyDel(string path);
        delegate int AnonymousDelegate(double rate);
        delegate Color LambdaDelegate(bool check);

        // ##################################| Variables
        private bool dragging = false; // "dragging" is used to track whether an item is currently being dragged on the screen
        private Point dragStart;       // "dragStart" stores the starting position of the drag operation
        private string imagePath = ""; // "imagePath" is used to store the path of the image being dragged (if any)


        // ##################################| Init
        public AppView()
        {
            // Initialize the form and its components
            InitializeComponent();

            // Create a rounded region for the form's edges using Windows API function CreateRoundRectRgn
            // This gives the form a rounded corner effect with a radius of 25 pixels
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // Set the initial value of the progress bar to 0%
            progressBar.Value = 0;

        }

        private void AppView_Load(object sender, EventArgs e)
        {
            init();
        }

        private async void init()
        {
            dateTimeLabel.Text = DateTime.Now.ToString();
            LineBar_Move(btn1);

            await checkConnection();
            imageCount();
            modelNameAndVersion();
        }

        // ##################################| Form methods

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


        // 2.#########| Drag and drop image 

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // Check whether the data being dragged is an image
            if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".jpg") ||
                ((string[])e.Data.GetData(DataFormats.FileDrop))[0].EndsWith(".png"))
            {
                // Allow the drag and drop operation to continue
                e.Effect = DragDropEffects.Copy;
            }

            imagePanel.Visible = true;
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            imagePanel.Visible = false;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the path of the dropped image file from the Data property of the DragEventArgs object
            imagePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            acceptImage();

            imagePanel.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ##################################| Controls methods
        private void LineBar_Move(object sender)
        {
            Button btn = (Button)sender;

            lineBar.Height = btn.Height;
            lineBar.Top = btn.Top;
            lineBar.Left = btn.Left;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        // 1.#########| Side bar
        private void btn_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LineBar_Move(sender);
        }

        // 2.#########| Check Connection
        private void CheckConnection_Click(object sender, EventArgs e)
        {
            if (labelServerInfo.Text != "loading...")
                init();
        }

        // 4.#########| Prediction button
        private void selectImage_Click(object sender, EventArgs e)
        {
            imagePath = openImagePicker();
            acceptImage();
        }

        // 5.#########| Prediction button
        private void btnPrediction_MouseHover(object sender, EventArgs e)
        {
            if (imagePath.Length == 0)
            {
                btnPrediction.Text = "Add image First";
            }
            else
            {
                btnPrediction.Text = "Prediction";
            }
        }

        private void btnPrediction_Click(object sender, EventArgs e)
        {
            if (imagePath.Length == 0)
            {
                // Get the image path
                imagePath = openImagePicker();
                acceptImage();
            }
            else
            {
                // Start Prediction
                Prediction();
            }
        }

        private void btnPrediction_MouseLeave(object sender, EventArgs e)
        {
            btnPrediction.Text = "Prediction";
        }

        // 5.#########| More Info button
        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            btnMoreInfo.Text = "Loading...";

            Form info = new MoreInfoView();
            info.ShowDialog();

            btnMoreInfo.Text = FlaskServer.patientDetection.Expectation.IsBrainDisease;
        }

        // ##############################| Methods
        private void acceptImage(string url = "")
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
            }
            else
            {
                if (imagePath.Length == 0) return;
                // Load the image into a Bitmap object
                image = new Bitmap(imagePath);
            }

            ImageBox.Image = image;
            labelDropImage.Text = "";

        }

        private string openImagePicker()
        {
            string path = imagePath;

            // Create a new instance of the OpenFileDialog class to allow the user to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";

            // If the user selects a file and clicks OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get the image path
                path = openFileDialog.FileName;

            }
            // reset the progressBar and Button
            progressBar.Value = 0;
            progressBar.Text = "";
            btnMoreInfo.Enabled = false;
            btnMoreInfo.Text = "";

            return path;
        }

        private async Task checkConnection()
        {
            labelServerInfo.Text = "Loading...";


            if (await FlaskServer.isServerRunning())
            {
                labelServerConnection.Text = "Connected";
                labelServerConnection.ForeColor = Color.Lime;

                labelServerInfo.Text = "Server is running in port: 5000";
            }
            else
            {
                labelServerConnection.Text = "Disconncted";
                labelServerConnection.ForeColor = Color.Red;

                labelServerInfo.Text = "Server down";
            }
        }

        private async void imageCount()
        {
            if (await FlaskServer.isServerRunning())
            {
                labelImageCount.Text = FlaskServer.Info.ImagesCount.ToString();
            }
            else
            {
                labelImageCount.Text = "0";
            }
        }

        private async void modelNameAndVersion()
        {
            if (await FlaskServer.isServerRunning())
            {
                labelModelName.Text = FlaskServer.Info.Model.Name;
                labelModelVersion.Text = "Version: " + FlaskServer.Info.Model.Version;
            }
            else
            {
                labelModelName.Text = "Info";
                labelModelVersion.Text = "";
            }
        }

        private async void Prediction()
        {
            btnPrediction.Text = "loading...";
            try
            {
                MyDel dl = new MyDel(FlaskServer.UploadImage); // #####################| 1.Delegate 
                PatientDetection patientDetection = await dl(path: imagePath);

                if (patientDetection == null) return;

                AnonymousDelegate getRate = delegate (double rate) // #####################| 2.Anonymous
                {
                    return Convert.ToInt32(rate * 100);
                };

                LambdaDelegate color = (isBrainDisease) => isBrainDisease ? Color.Red : Color.Green; // #####################| 3.Lambda

                String text = patientDetection.Expectation.IsBrainDisease;
                Color col = color(check: text == BrainDisease.Positive.ToString());

                progressBar.Text = getRate(rate: patientDetection.Expectation.ConfirmationRate).ToString() + "%";
                progressBar.Value = getRate(rate: patientDetection.Expectation.ConfirmationRate);
                progressBar.ForeColor = col;
                progressBar.ProgressColor = col;

                btnMoreInfo.Enabled = true;
                btnMoreInfo.Text = text;
                btnMoreInfo.ForeColor = col;

                imageCount();
                btnPrediction.Text = "Done";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

                btnPrediction.Text = "Error";
            }
        }
    }
}
