
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

namespace Sistema.Control.Asistencia
{
    public partial class formRegAsistencia : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels= new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t, i=0;
        string name, names = null, curp="";
        SqlConnection conexion;
        Empleado emp;
        List<Empleado> empleados;


        public formRegAsistencia(SqlConnection con)
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();

            this.conexion = con;
            this.emp = new Empleado();
            this.empleados = this.emp.ListarEmpleados(this.conexion);

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
                MessageBox.Show("No hay datos binarios, por favor agregar las fotos de los empleados.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
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
                    curp = name;
                    names = "";
                    //Clear the list(vector) of names
                    NamePersons.Clear();

                }

        private void formRegAsistencia_Load(object sender, EventArgs e)
        {
            llenarCMBEmpleados();
            timerDia.Enabled = true;
            lblIdTarjeta.Text = "";
        }

        private void llenarCMBEmpleados()
        {
            cmbEmpleados.Items.Clear();
            foreach (Empleado e in this.empleados)
            {
                cmbEmpleados.Items.Add(e.getClave());
            }

        }

        private void timerDia_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
            txtHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedItem.ToString() != "" || cmbEmpleados.SelectedItem.ToString() != null) 
            {
                this.emp = new Empleado((int) cmbEmpleados.SelectedItem,this.conexion);
                btnRegistrar.Enabled = true;
            }
        }

        private void rbtnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTarjeta.Checked == true)
            {
                lblPuerto.Enabled = true;
                cmbPuerto.Enabled = true;
                lblIdTarjeta.Enabled = true;
                picbxTarjeta.Enabled = true;
                btnLectura.Enabled = true;
            }
            else 
            {
                lblPuerto.Enabled = false;
                cmbPuerto.Enabled = false;
                lblIdTarjeta.Enabled = false;
                picbxTarjeta.Enabled = false;
                btnLectura.Enabled = false;
            }
        }

        private void rbtnFacial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFacial.Checked == true)
            {
                imageBoxFrameGrabber.Enabled = true;
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
            }
            else
            {
                imageBoxFrameGrabber.Enabled = false;
                btnIniciar.Enabled = false;
                btnDetener.Enabled = false;
            }
        }

        private void cmbPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPuerto.SelectedItem.ToString())
            {
                case "COM1": serialArduino.PortName = "COM1"; btnLectura.Enabled = true; break;
                case "COM2": serialArduino.PortName = "COM2"; btnLectura.Enabled = true; break;
                case "COM3": serialArduino.PortName = "COM3"; btnLectura.Enabled = true; break;
                case "COM4": serialArduino.PortName = "COM4"; btnLectura.Enabled = true; break;
                case "COM5": serialArduino.PortName = "COM5"; btnLectura.Enabled = true; break;
                case "COM6": serialArduino.PortName = "COM6"; btnLectura.Enabled = true; break;
                case "COM7": serialArduino.PortName = "COM7"; btnLectura.Enabled = true; break;
                case "COM8": serialArduino.PortName = "COM8"; btnLectura.Enabled = true; break;
                case "COM9": serialArduino.PortName = "COM9"; btnLectura.Enabled = true; break;
                case "COM10": serialArduino.PortName = "COM10"; btnLectura.Enabled = true; break;
                case "": break;
                case null: break;
            }
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            serialArduino.Open();
            timerComSerial.Enabled = true;
        }

        private void timerComSerial_Tick(object sender, EventArgs e)
        {
            string codigo = serialArduino.ReadLine();
            if (i == 0)
            {
                MessageBox.Show("Comunicación serial activada, por favor pase su tarjeta por el lector RFID.", "Mensaje de inicio de lectura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!codigo.Equals(""))
            {
                MessageBox.Show("Tarjeta detectada con el ID: " + codigo, "Mensaje de lectura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIdTarjeta.Text = codigo;
                serialArduino.Close();
                i = 0;
                timerComSerial.Enabled = false;
            }
            if (i == 50)
            {
                MessageBox.Show("Comunicación serial terminada." + codigo, "Mensaje de terminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialArduino.Close();
                i = 0;
                timerComSerial.Enabled = false;
            }
            i++;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EntradaLaboral ent;
            SalidaLaboral sal;
            DiaLaboral dia;
            if (rbtnFacial.Checked == true)
            {
                if (curp.Equals(this.emp.getCURP()))
                {
                    DialogResult rs = MessageBox.Show("¿Realmente desea registrar la asistencia con el empleado seleccionado?", "Registro de asistencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs.Equals(DialogResult.OK))
                    {
                        if (DateTime.Now.Hour <= this.emp.getHoraEnt().Hours + 1 && DateTime.Now.Hour <= this.emp.getHoraSal().Hours - 1)
                        {
                            ent = new EntradaLaboral();
                            ent.setFechaEnt(new Date(DateTime.Now));
                            ent.setHoraEnt(new Time(DateTime.Now));
                            ent.setIdEmpleado(this.emp.getClave());
                            int r = ent.insertarEntradaBD(this.conexion);
                            if (r > 0)
                            {
                                MessageBox.Show("La entrada laboral fue registrada satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("La entrada no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (DateTime.Now.Hour <= this.emp.getHoraSal().Hours + 1 && DateTime.Now.Hour > this.emp.getHoraEnt().Hours + 1)
                            {
                                sal = new SalidaLaboral();
                                sal.setFechaSal(new Date(DateTime.Now));
                                sal.setHoraSal(new Time(DateTime.Now));
                                sal.setIdEmpleado(this.emp.getClave());
                                int r = sal.insertarSalidaBD(this.conexion);
                                if (r > 0)
                                {
                                    MessageBox.Show("La salida laboral fue registrada satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ent = new EntradaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);
                                    sal = new SalidaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);

                                    dia = new DiaLaboral();
                                    dia.setFecha(sal.getFechaSal());
                                    dia.setIdEmpleado(sal.getIdEmpleado());
                                    dia.setIdHoraSal(sal.getIdSalida());
                                    if (ent.getIdEntrada() != 0)
                                    {
                                        dia.setIdHoraEnt(ent.getIdEntrada());
                                        if (ent.getHoraEnt().Minutes > 15)
                                        {
                                            dia.setAsistencia(DiaLaboral.Asistencia.Retardo);
                                            dia.insertarDiaBD(this.conexion);
                                        }
                                        else
                                        {
                                            dia.setAsistencia(DiaLaboral.Asistencia.Presente);
                                            dia.insertarDiaBD(this.conexion);
                                        }
                                    }
                                    else
                                    {
                                        ent = new EntradaLaboral();
                                        ent.setFechaEnt(new Date(DateTime.Now));
                                        ent.setIdEmpleado(this.emp.getClave());
                                        ent.setHoraEnt(new Time(0, 0, 0));
                                        ent.insertarEntradaBD(this.conexion);
                                        ent = new EntradaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);
                                        dia.setIdHoraEnt(ent.getIdEntrada());
                                        dia.setAsistencia(DiaLaboral.Asistencia.Falta);
                                        dia.insertarDiaBD(this.conexion);
                                        MessageBox.Show("Día laboral registrado como falta por no tener registro de entrada del día.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("La salida no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Es imposible registrar una entrada o salida una hora despues del horario registrado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Empleado no identificado de manera correcta", "Mesaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (lblIdTarjeta.Text.Equals(this.emp.getIdTarjeta()))
                {
                    DialogResult rs = MessageBox.Show("¿Realmente desea registrar la asistencia con el empleado seleccionado?", "Registro de asistencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (rs.Equals(DialogResult.OK))
                    {
                        if (DateTime.Now.Hour <= this.emp.getHoraEnt().Hours + 1 && DateTime.Now.Hour <= this.emp.getHoraSal().Hours - 1)
                        {
                            ent = new EntradaLaboral();
                            ent.setFechaEnt(new Date(DateTime.Now));
                            ent.setHoraEnt(new Time(DateTime.Now));
                            ent.setIdEmpleado(this.emp.getClave());
                            int r = ent.insertarEntradaBD(this.conexion);
                            if (r > 0)
                            {
                                MessageBox.Show("La entrada laboral fue registrada satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("La entrada no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (DateTime.Now.Hour <= this.emp.getHoraSal().Hours + 1 && DateTime.Now.Hour > this.emp.getHoraEnt().Hours + 1)
                            {
                                sal = new SalidaLaboral();
                                sal.setFechaSal(new Date(DateTime.Now));
                                sal.setHoraSal(new Time(DateTime.Now));
                                sal.setIdEmpleado(this.emp.getClave());
                                int r = sal.insertarSalidaBD(this.conexion);
                                if (r > 0)
                                {
                                    MessageBox.Show("La salida laboral fue registrada satisfactoriamente.", "Mensaje de Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    ent = new EntradaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);
                                    sal = new SalidaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);

                                    dia = new DiaLaboral();
                                    dia.setFecha(sal.getFechaSal());
                                    dia.setIdEmpleado(sal.getIdEmpleado());
                                    dia.setIdHoraSal(sal.getIdSalida());
                                    if (ent.getIdEntrada() != 0)
                                    {
                                        dia.setIdHoraEnt(ent.getIdEntrada());
                                        if (ent.getHoraEnt().Minutes > 15)
                                        {
                                            dia.setAsistencia(DiaLaboral.Asistencia.Retardo);
                                            dia.insertarDiaBD(this.conexion);
                                        }
                                        else
                                        {
                                            dia.setAsistencia(DiaLaboral.Asistencia.Presente);
                                            dia.insertarDiaBD(this.conexion);
                                        }
                                    }
                                    else
                                    {
                                        ent = new EntradaLaboral();
                                        ent.setFechaEnt(new Date(DateTime.Now));
                                        ent.setIdEmpleado(this.emp.getClave());
                                        ent.setHoraEnt(new Time(0, 0, 0));
                                        ent.insertarEntradaBD(this.conexion);
                                        ent = new EntradaLaboral(this.emp.getClave(), new Date(DateTime.Now), this.conexion);
                                        dia.setIdHoraEnt(ent.getIdEntrada());
                                        dia.setAsistencia(DiaLaboral.Asistencia.Falta);
                                        dia.insertarDiaBD(this.conexion);
                                        MessageBox.Show("Día laboral registrado como falta por no tener registro de entrada del día.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La salida no pudo ser registrada.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Es imposible registrar una entrada o salida una hora despues del horario registrado.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Empleado no identificado de manera correcta", "Mesaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void serialArduino_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString(),"Mensaje de error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            Close();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
        }

        private void formRegAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
        }

    }
}