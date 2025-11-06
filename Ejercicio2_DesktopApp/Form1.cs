using System.Runtime.Serialization.Formatters.Binary;
using Ejercicio1_Models;

namespace Ejercicio2_DesktopApp
{
    public partial class Form1 : Form
    {

        Sistema miEmpresa = new Sistema();
        int camionElegido = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarListaZonas()
        {
            //Metodo para mostrar la lista de zonas en el listBox correspondiente, consigna 2
            listBz1.Items.Clear();
            listBz2.Items.Clear();
            listBz3.Items.Clear();

            foreach (Paquete paquete in miEmpresa.listaPaquetes)
            {
                if (paquete.ZonaDestino == 1)
                {
                    listBz1.Items.Add(paquete);
                }
                else if (paquete.ZonaDestino == 2)
                {
                    listBz2.Items.Add(paquete);
                }
                else if (paquete.ZonaDestino == 3)
                {
                    listBz3.Items.Add(paquete);
                }
            }

        }
        private void VerCarga()//lee la carga del camion y la dispara sobre el listboxcarga consigna 2
        {
            listBcargas.Items.Clear();
            string[] carga = miEmpresa.VerCargaCamion(camionElegido);
            
            foreach (string paquete in carga)
            {
                string[] dato = paquete.Split(";");
                listBcargas.Items.Add(new Paquete(int.Parse(dato[0]), double.Parse(dato[1]), int.Parse(dato[2])));
            }
        }




        //Consigna 4
        private void Form1_Load(object sender, EventArgs e) // persistencia, consigna 4
        {

            //se puede usar using pero no estoy acostumbrado, en el examen lo resolvi similar a esto
            FileStream archivo = new FileStream("sistema.bin", FileMode.OpenOrCreate, FileAccess.Read);
            if (archivo.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                miEmpresa = (Sistema)formatter.Deserialize(archivo);//Estoy seguro que en vez de poner "Deserialize" puse algo como "Read", deberia ser Deserialize
            }
            archivo.Close();

            //inicializo los listBox
            MostrarListaZonas();

            foreach (string s in miEmpresa.CamionesCargados())
            {
                cBoxCamiones.Items.Add(s);
            }
            string[] camiones = miEmpresa.CamionesCargados();
            
            if (cBoxCamiones.Items.Count > 0)
            {
                cBoxCamiones.SelectedIndex = 0;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//persistencia consigna 4
        {
            FileStream archivo = new FileStream("sistema.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(archivo, miEmpresa);//Estoy seguro que en vez de poner "Serialize" puse algo como "Write", deberia ser Serialize
            archivo.Close();
        }

        private void btnImportarPaquetesPedidos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream archivo = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    miEmpresa.Descargar(archivo);
                    archivo.Close();
                    MostrarListaZonas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar paquetes: " + ex.Message);
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int seleccionado = cBoxCamiones.SelectedIndex;

            camionElegido = seleccionado;
            VerCarga();
            tBkg.Text = 0.ToString();


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //generamos el csv con el selectedIndex y carga.csv de nombre
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                    string path = $"{camionElegido}carga.csv";
                    FileStream archivo = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                    miEmpresa.RetirarCamion(archivo, camionElegido);
                    archivo.Close();




                //actualizo la lista de camiones en el comboBox
                cBoxCamiones.Items.Clear();

                foreach (string s in miEmpresa.CamionesCargados())
                {
                    cBoxCamiones.Items.Add(s);
                }
                if (cBoxCamiones.Items.Count > 0)
                {
                    cBoxCamiones.SelectedIndex = 0;
                    camionElegido = 0;
                    VerCarga();
                }
                tBkg.Text = 0.ToString();
                listBcargas.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el camion: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (camionElegido >= 0)
                {
                    Paquete? p = null;
                    if (listBz3.Items.Count > 0)
                    {
                        p = listBz3.Items[(listBz3.Items.Count - 1)] as Paquete;
                        if(p!= null)
                        {
                            double peso = miEmpresa.CargarPaquete(camionElegido, p);

                            listBz3.Items.Remove(p);
                            listBcargas.Items.Add(p);

                            tBkg.Text = peso.ToString();
                        }
                    }
                    else if (listBz2.Items.Count > 0)
                    {
                        p = listBz2.Items[(listBz2.Items.Count - 1)] as Paquete;
                        if (p != null)
                        {
                            double peso = miEmpresa.CargarPaquete(camionElegido, p);

                            listBz2.Items.Remove(p);
                            listBcargas.Items.Add(p);

                            tBkg.Text = peso.ToString();
                        }
                    }
                    else if (listBz1.Items.Count > 0)
                    {
                        p = listBz1.Items[(listBz1.Items.Count - 1)] as Paquete;
                        if (p != null)
                        {
                            double peso = miEmpresa.CargarPaquete(camionElegido, p);

                            listBz1.Items.Remove(p);
                            listBcargas.Items.Add(p);

                            tBkg.Text = peso.ToString();
                        }
                    }
                    else
                    {
                        throw new Exception("No hay paquetes para agregar.");
                    }

                    MostrarListaZonas();
                    VerCarga();
                }
                else
                {
                    throw new Exception("No hay ningun camion seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el paquete al camion: " + ex.Message);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //quita el ultimo paquete cargado y lo devuelve a la zona correspondiente
            try
            {
                if (listBcargas.Items.Count > 0)
                {
                    Paquete? p = null;
                    p = listBcargas.Items[(listBcargas.Items.Count - 1)] as Paquete;


                    if (p != null)
                    {
                        double peso = miEmpresa.RetirarPaquete(camionElegido);

                        listBcargas.Items.Remove(p);
                        if (p.ZonaDestino == 1)
                        {
                            listBz1.Items.Add(p);
                        }
                        else if (p.ZonaDestino == 2)
                        {
                            listBz2.Items.Add(p);
                        }
                        else if (p.ZonaDestino == 3)
                        {
                            listBz3.Items.Add(p);
                        }
                        else
                        {
                            throw new Exception("Zona de destino del paquete invalida.");
                        }

                        tBkg.Text = peso.ToString();
                        MostrarListaZonas();
                        VerCarga();
                    }
                    else{
                        throw new Exception("Error al obtener el paquete del camion.");
                    }
                    
                }
                else
                {
                    throw new Exception("No hay paquetes para retirar del camion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retirar el paquete del camion: " + ex.Message);
            }
        }
    }
}
