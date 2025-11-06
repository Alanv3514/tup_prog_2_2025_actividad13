namespace Ejercicio1_Models
{
    [Serializable]
    public class Sistema
    {
        private List<Camion> listaCamiones = new List<Camion>();
        public List<Paquete> listaPaquetes = new List<Paquete>();
        public Sistema() {
        //esto en el examen no lo puse pero tendria que haber hardcodeado unos camiones
            Camion camion1 = new Camion("ABC123", 2000);
            Camion camion2 = new Camion("DEF456", 200);
            Camion camion3 = new Camion("GHI789", 500);

            listaCamiones.Add(camion1);
            listaCamiones.Add(camion2);
            listaCamiones.Add(camion3);
        }

        public string[] CamionesCargados()
        {
            int i = 0;
            string[] camiones = new string[listaCamiones.Count];
            foreach (Camion camion in listaCamiones)
            {
                camiones[i] = $"{camion.Patente.ToString()}:{camion.PesoMaximo.ToString()}";
                i++;
            }
            return camiones;
        }
        public void Descargar(Stream archivo)//este se usa para el boton Importar Paquetes Pedidos
        {
            StreamReader sr = new StreamReader(archivo);
            string linea;
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(';');
                int nroRegistro = int.Parse(datos[0]);
                double peso = double.Parse(datos[1]);
                int zonaDestino = int.Parse(datos[2]);
                Paquete paquete = new Paquete(nroRegistro, peso, zonaDestino);
                listaPaquetes.Add(paquete);
            }

        }

        public void RetirarCamion(FileStream archivo, int posicion)
        {
            StreamWriter sw = new StreamWriter(archivo);
            try
            {
                string[] carga = VerCargaCamion(posicion);

                foreach (string paquete in carga)
                {
                    sw.WriteLine(paquete);
                }

                //no entendi bien si se debia eliminar el camion de la lista o no
                listaCamiones.Remove(listaCamiones[posicion]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al retirar el camion: " + ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }
        public double CargarPaquete (int posicion, Paquete paquete)
        {
            double ret = 0;
            Camion camionSeleccionado = listaCamiones[posicion];//en el examen lo hice con foreach pero no es necesario
            try
            {
                bool cargaExitosa = camionSeleccionado.AgregarPaquete(paquete);
                if (cargaExitosa)
                {
                    listaPaquetes.Remove(paquete);
                    ret = camionSeleccionado.CargaEnKg();
                }

                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar el paquete: " + ex.Message);
            }
        }
        public double RetirarPaquete(int posicion)
        {
            Camion camionSeleccionado = listaCamiones[posicion];//en el examen lo hice con foreach pero no es necesario
            try
            {
                Paquete paqueteRetirado = camionSeleccionado.QuitarPaquete();
                listaPaquetes.Add(paqueteRetirado);
                return camionSeleccionado.CargaEnKg();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al retirar el paquete: " + ex.Message);
            }
            
        }
        public string[] VerCargaCamion(int posicion)
        {
            string[] carga = new string[listaCamiones.Count];
            try
            {

                Camion camionSeleccionado = listaCamiones[posicion];//en el examen lo hice con foreach pero no es necesario
                carga = camionSeleccionado.VerCarga();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
            return carga;
        }


    }
}
