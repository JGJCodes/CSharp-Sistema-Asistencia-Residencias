
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;

namespace Sistema.Control.Asistencia
{
    public partial class formCapturarFoto : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        
        public formCapturarFoto()
        {
            InitializeComponent();
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            btnIniciar.Enabled = false;
            btnCapturar.Enabled = true;
        }


        void FrameGrabber(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(450, 247, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
         }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            saveFileDialogo.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialogo.Title = "Save an Image File";
            saveFileDialogo.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialogo.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialogo.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialogo.FilterIndex)
                {
                    case 1:
                        currentFrame.ToBitmap().Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        currentFrame.ToBitmap().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        currentFrame.ToBitmap().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void formCapturarFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            btnCapturar.Enabled = false;
            btnIniciar.Enabled = true;
            btnFoto.Enabled = true;
        }

    }
}