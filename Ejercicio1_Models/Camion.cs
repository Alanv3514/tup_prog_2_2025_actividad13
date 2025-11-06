namespace Ejercicio1_Models
{
    [Serializable]
    public class Camion
    {
        private double pesoControl = 0;
        public string Patente { get; set; }
        public double PesoMaximo { get; set; }

        public Stack<Paquete> manifiesto = new Stack<Paquete>();

        public Camion(string patente, double pesoMaximo)
        {
            this.Patente = patente;
            this.PesoMaximo = pesoMaximo;
         }

        public bool AgregarPaquete(Paquete unPaquete)
        {
            bool res = false;
            double pesoTotal = this.pesoControl + unPaquete.Peso;
            if (pesoTotal <= this.PesoMaximo)
            {
                this.manifiesto.Push(unPaquete);
                this.pesoControl += unPaquete.Peso;
                res = true;
            }
            else
            {//Lanzamiento de excepcion en el metodo AgregarPaquete como lo pide la consigna 3
                throw new Exception("No se puede agregar el paquete: excede el peso maximo del camion.");
            }

                return res;
        }

        public double CargaEnKg()
        {
            return this.pesoControl;
        }
        public Paquete QuitarPaquete()
        {
            Paquete paqueteRetirado = null;
            if (this.manifiesto.Count > 0)
            {
                paqueteRetirado = this.manifiesto.Pop();
                this.pesoControl -= paqueteRetirado.Peso;
            }
            else
            {
                throw new Exception("No hay paquetes para retirar del camion.");
            }
            return paqueteRetirado;
        }   
        public string[] VerCarga()
        {
            string[] carga = new string[this.manifiesto.Count];
            int indice = 0;
            foreach (Paquete paquete in this.manifiesto)
            {
                carga[indice] = paquete.ToString();
                indice++;
            }
            return carga;
        }   
    }
}
