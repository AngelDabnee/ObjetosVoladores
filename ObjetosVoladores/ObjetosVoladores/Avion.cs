using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    //Haremos la herencia de vehiculo y de la interface. 
    public class Avion : Vehiculo, IVolador
    {
        public Avion()
        {
            this.estado = EstadoVehiculo.APAGADO;
            this.combustible = "Requiere JET A";
            this.llantas = 3;
            this.capacidad = 41000;
        }
        public void aterrizar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO)
            {
                Console.WriteLine("El avion puede iniciar el aterrizaje");
                this.estado = EstadoVehiculo.ATERRIZANDO;
            }
        }

        public void despegar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO)
            {
                Console.WriteLine("Inicializando el despegue");
                this.estado = EstadoVehiculo.DESPEGANDO;
            }
        }

        public string volar(int tiempo)
        {
                tiempo = 123;
                Console.WriteLine("Para poder iniciar el vuelo se necesita " + tiempo + "km/hr");
                return tiempo.ToString();
        }

        protected override void apagar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO) 
            {
                Console.WriteLine("Ahora puedes apagar el avion");
                this.estado = EstadoVehiculo.APAGADO;
            }
        }

        protected override void comunicar(string msg)
        {
            msg = "El avión se comunica mediante radio satelital ";
            Console.WriteLine(msg);
        }

        protected override void encender()
        {
            if (this.estado == EstadoVehiculo.APAGADO)
            {
                Console.WriteLine("Se encenderá el avion");
                this.estado = EstadoVehiculo.ENCENDIDO;
            }
            else
            {
                Console.WriteLine("apaga el avion");
            }
        }
        public void Encender() 
        {
            encender();
        }
        public void Apagar() 
        {
            apagar();
        }
        public void Comunicar() 
        {
            Console.WriteLine("El avión requiere de microfono y bocina para su comunicación.");
        }
        public string ToString() 
        {
            return $"El avión esta {this.estado} por lo cual iniciamos las operaciones, este necesita " +
                $"{this.combustible} tiene un total de {this.llantas} tiene una capacidad de {this.capacidad} de kg, promedio. ";
        }
    }
}