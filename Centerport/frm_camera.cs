using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCam_Capture;
using WinFormCharpWebCam;
using AForge.Video;
using Accord.Video.DirectShow;
using System.Threading;


namespace MedicalManagementSoftware
{
       



    public partial class frm_camera : Form
    {
        //private Drawing2D _interpolationMode;
        private const long BUTTON_DOWN_CODE = 0xa1;
        private const long BUTTON_UP_CODE = 0xa0;
        private const long WM_MOVING = 0x216;
        static bool left_button_down = false;
        //public string path = @"C:\Users\Mark\AppData\Roaming\tmp.jpg";



       
        public frm_camera()
        {
            InitializeComponent();
        }
        WebCam webcam;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void frm_camera_Load(object sender, EventArgs e)
        {
            
            //loadCam();


            //if (File.Exists(path))
            //{
            //    File.Delete(path);

            //}

            closeCamera();



            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
                cboCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }

            //Thread.Sleep(2000);

            imgCapture.SizeMode = PictureBoxSizeMode.CenterImage;
            imgVideo.SizeMode = PictureBoxSizeMode.CenterImage;


            imgVideo.Visible = true;
            //imgCapture.Visible = false;
            //



            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            videoCaptureDevice.Start();




        }


    


        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            //Check the state of the Left Mouse Button
            if ((long)m.Msg == BUTTON_DOWN_CODE)
                left_button_down = true;
            else if ((long)m.Msg == BUTTON_UP_CODE)
                left_button_down = false;

            if (left_button_down)
            {
                if ((long)m.Msg == WM_MOVING)
                {
                    //Set the forms opacity to 50% if user is moving
                    if (this.Opacity != 0.5)
                        this.Opacity = 0.5;
                }
            }

            else if (!left_button_down)
                if (this.Opacity != 1.0)
                    this.Opacity = 1.0;

            base.DefWndProc(ref m);
        }

        private void frm_camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                webcam.Stop();
                imgCapture.Image.Dispose();
                imgCapture.Image = null;


            }
            catch
            { }


            //closeCamera();

           
        }
      
        private void closeCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning == true)
            {
                //videoCaptureDevice.Stop();
                Invoke((MethodInvoker)delegate
                {
                    //videoCaptureDevice.SignalToStop();
                    //videoCaptureDevice.WaitForStop();
                    videoCaptureDevice.SignalToStop();
                    // FinalVideo.WaitForStop();  << marking out that one solved it
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    //videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // as sugested
                    videoCaptureDevice = null;


                });


            }

            


        }

        public void RecursiveDelete(string path, string name)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                if (directory.EndsWith("\\" + name))
                {
                    Directory.Delete(directory, true);
                }
                else
                {
                    RecursiveDelete(directory, name);
                }
            }
        }

        private void cmd_capture_Click(object sender, EventArgs e)
        {
            if (imgVideo.Image != null)
            {

            

            Image img = imgVideo.Image;

            int newWidth = 320;
            int newHeight = 230;

            Bitmap resizedImage = new Bitmap(img, newWidth, newHeight);


            imgCapture.Image = img;

            imgVideo.Visible = false;
            imgCapture.Visible = true;
            cmd_reset.Enabled = true; 
            cmd_save.Enabled = true; 
            cmd_capture.Enabled = false;



            closeCamera();
            //
        }
           

        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            try
            {
               
                imgCapture.Image = null;
                imgVideo.Visible = true;
                imgCapture.Visible = false;
               
               

                cmd_reset.Enabled = false; 
                cmd_save.Enabled = false;

                cmd_capture.Enabled = true;

                //cmdStartCamera.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       //
     
        private void cmd_save_Click(object sender, EventArgs e)
        {

            if (System.Windows.Forms.Application.OpenForms["frm_addPatient"] != null)
            {
             //   (System.Windows.Forms.Application.OpenForms["frm_seafarer_MEC"] as frm_seafarer_MEC).Search_Patient();
                //frm_addPatient.img.SizeMode = PictureBoxSizeMode.Normal;
                frm_addPatient.img.Image = imgCapture.Image;
                
            }
            else if (System.Windows.Forms.Application.OpenForms["frm_patientInfo"] != null)
            {
                //frm_patientInfo.img.SizeMode = PictureBoxSizeMode.Normal;

                frm_patientInfo.img.Image = imgCapture.Image;
                
            
            }

                   
          
            this.Close();
          
        }


        //private void saveToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Helper.SaveImageCapture(imgCapture.Image);
        //}

        private void imgCapture_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)//here i have use mouse click left button only
            //{
            //    imgCapture.Refresh();
            //    cropX = e.X;
            //    cropY = e.Y;
            //    Cursor = Cursors.Cross;
            //}
            //imgCapture.Refresh();
        }

        private void imgCapture_MouseUp(object sender, MouseEventArgs e)
        {
   
        }
        

        private void imgCapture_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
      

        private void imgCapture_Paint(object sender, PaintEventArgs e)
        {

        }

  
      

     

        private void VideoCaptureDevice_NewFrame(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                imgVideo.Image = (Bitmap)eventArgs.Frame.Clone();
                //imgVideo.Image = (Bitmap)eventArgs.Frame.GetThumbnailImage(frameSize.Width, frameSize.Height, new Image.GetThbnailImageAbort(imageconvertcallback), IntPtr.Zero);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
           
            //imgCapture.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeCamera();



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);

                int newWidth = 320;
                int newHeight = 230;

                Bitmap resizedImage = new Bitmap(img, newWidth, newHeight);


                imgCapture.Image = img;

                imgVideo.Visible = false;
                imgCapture.Visible = true;
                cmd_reset.Enabled = true;
                cmd_save.Enabled = true;
                cmd_capture.Enabled = false;
            }
        }


        void loadCam()
        {
            Cursor.Current = Cursors.Default;
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
            webcam.Start();


            imgVideo.Visible = true;
            //imgCapture.Visible = true;
            cmd_reset.Enabled = false;
            cmd_save.Enabled = false;
            cmd_capture.Enabled = true;
            //cmdStartCamera.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            imgVideo.Visible = true;
            //imgCapture.Visible = true;
            cmd_reset.Enabled = false;
            cmd_save.Enabled = false;
            cmd_capture.Enabled = true;
            //cmdStartCamera.Enabled = false;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            videoCaptureDevice.Start();

        }
       
     


    }
}
