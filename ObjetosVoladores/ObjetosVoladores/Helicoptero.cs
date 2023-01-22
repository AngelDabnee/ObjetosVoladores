using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public class Helicoptero : Vehiculo, IVolador, ITransporte
    {
        public Helicoptero() 
        {
            Console.WriteLine("Comenzaremos la creación de un helicopterochiquito");
            this.estado = EstadoVehiculo.DETENIDO;
            this.combustible = "JET fuel";
            this.llantas = 4;
            this.capacidad = 14000;
        }

        public void aterrizar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO) 
            {
                Console.WriteLine("Podemos iniciar el proceso de aterrizar, que es estabilizar el vuelo, colocarnos en la plataforma y bajar lento");
                this.estado = EstadoVehiculo.ATERRIZANDO;
            }
        }

        public void despegar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO) 
            {
                Console.WriteLine("Puedes iniciar el despegue al alcanzar una velocidad de helices de 1000 kg/hr");
                this.estado = EstadoVehiculo.DESPEGANDO;
            }
        }

        public string volar(int tiempo)
        {
            tiempo = 132;
            Console.WriteLine($"El tiempo de vuelo promedio es de {tiempo}");
            return tiempo.ToString();
        }

        protected override void apagar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO && this.estado == EstadoVehiculo.DETENIDO) 
            {
                Console.WriteLine("Puedes iniciar el apagado del helicoptero");
                this.estado = EstadoVehiculo.APAGADO;
            }
        }

        protected override void comunicar(string msg)
        {
            //Programamos el sistema de comunicación directo. 
        }

        protected override void encender()
        {
            if (this.estado == EstadoVehiculo.DETENIDO) 
            {
                Console.WriteLine("Para iniciar el proceso de encender el helicoptero, necesitamos meterle la llave abrir el sistema y encender un boton");
                this.estado = EstadoVehiculo.ENCENDIDO;
            }
        }
        public void Apagar() 
        {
            apagar();
        }
        public void Comunicar() 
        {
            comunicar("Se comunica por medio de radio ");
        }
        public void Encender() 
        {
            encender();
        }

        public bool carga()
        {
            return false;
        }

        public bool descarga()
        {
            Console.WriteLine("Este Helicoptero se utiliza para desargar");
            return true;
        }
        public string ToString() 
        {
            return $"El estado del vehiculo es {this.estado} utiliza combustible tipo {this.combustible} " +
                $"cuenta con un total de {this.llantas} pesa un total de {this.capacidad} kg";
        }
    }//llave de la clase
}//llave del namespace
