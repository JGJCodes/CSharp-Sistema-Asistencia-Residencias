using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using Sistema.Control.Asistencia.Clases;

namespace Sistema.Control.Asistencia.Formularios
{
    public partial class formNeuronal : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        SqlConnection conexion;
        

        public formNeuronal(SqlConnection con)
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            this.conexion = con;
            
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels+1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            
            }
            catch(Exception e)
            {
                MessageBox.Show("No hay datos binarios, por favor agregar las fotos de los empleados.", "Carga de datos binarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            gpbxEmpleado.Enabled = true;
        }


        private void btnAgregarFoto_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                for (int i = 0; i < 10; i++)
                {
                    trainingImages.Add(TrainedFace);
                    labels.Add(cmbEmpleados.SelectedItem.ToString());
                }
                

                //Show face added in gray scale
                imgbxEmpleado.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show("Foto agregada a la red con el empleado: "+cmbEmpleados.Text , "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Es necesario detectar la cara primero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        void FrameGrabber(object sender, EventArgs e)
        {
           
            NamePersons.Add("");

            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    //Convert it to Grayscale
                    gray = currentFrame.Convert<Gray, Byte>();

                    //Face Detector
                    MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                  face,
                  1.2,
                  10,
                  Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                  new Size(20, 20));

                    //Action for each element detected
                    foreach (MCvAvgComp f in facesDetected[0])
                    {
                        t = t + 1;
                        result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                        if (trainingImages.ToArray().Length != 0)
                        {
                            //TermCriteria for face recognition with numbers of trained images like maxIteration
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                        //Eigen face recognizer
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                           trainingImages.ToArray(),
                           labels.ToArray(),
                           3000,
                           ref termCrit);

                        name = recognizer.Recognize(result);

                            //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                        }

                            NamePersons[t-1] = name;
                            NamePersons.Add("");
                    }
                        t = 0;

                        //Names concatenation of persons recognized
                    for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                    {
                        names = names + NamePersons[nnn] + ", ";
                    }
                    //Show the faces procesed and recognized
                    imageBoxFrameGrabber.Image = currentFrame;
                    
                    names = "";
                    //Clear the list(vector) of names
                    NamePersons.Clear();

        }

        private void formNeuronal_Load(object sender, EventArgs e)
        {
            llenarCMBEmpleados();
        }

        private void llenarCMBEmpleados() 
        {
            cmbEmpleados.Items.Clear();
            Empleado emp = new Empleado();
            List<Empleado> empleados = emp.ListarEmpleados(this.conexion);
            foreach (Empleado e in empleados) 
            {
                cmbEmpleados.Items.Add(e.getCURP());
            }
            
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedItem.ToString()!="" || cmbEmpleados.SelectedItem.ToString()!=null)
                btnAgregarFoto.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            gpbxEmpleado.Enabled = false;
        }

        private void formNeuronal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
        }

    }
}