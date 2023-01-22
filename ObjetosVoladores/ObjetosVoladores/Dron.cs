using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ObjetosVoladores
{
    //Se hace la herencia de dron con la clase abstracta vehiculos
    public class Dron : Vehiculo, IVolador
    {
        //Constructor, construye objetos en la memoria RAM
        //Le estamos dando valores a que es mi DRON, su estado, combustible.
        public Dron()
        {
            Console.WriteLine("Creando Dron");
            this.estado = EstadoVehiculo.ENCENDIDO;
            this.combustible = "Baterias AAA";
            this.llantas = 0;
            this.capacidad = 1.1;
        }
        //Se implementaron las interaces de IVolador de manera implicita. 
        public void aterrizar()
        {
            if (this.estado == EstadoVehiculo.VOLANDO)
            {
                Console.WriteLine("Este dron puede iniciar el aterrizaje");
                this.estado = EstadoVehiculo.ATERRIZANDO;
            }
        }

        public void despegar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO && this.estado == EstadoVehiculo.DETENIDO)
            {
                Console.WriteLine("Iniciando el despegue");
                this.estado = EstadoVehiculo.DESPEGANDO;
            }
        }

        public string volar(int tiempo)
        {
            if (this.estado != EstadoVehiculo.ATERRIZANDO && this.estado == EstadoVehiculo.ENCENDIDO)
            {
                tiempo = 12;
                Console.WriteLine($"Tu dron lleva un total de {tiempo} minutos");
            }
                return tiempo.ToString();
        }

        //Métodos Heredados. 
        protected override void apagar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO)

                if (this.estado == EstadoVehiculo.DETENIDO)
                {
                    Console.WriteLine("El carro se sí puede apagar");
                    this.estado = EstadoVehiculo.APAGADO;
                }
                else
                {
                    Console.WriteLine("Se debe detener el vehiculo antes de apagarse");
                }

            else
            {
                Console.WriteLine("Encender el carro");
            }
        }


        protected override void comunicar(string msg)
        {
            if (this.estado == EstadoVehiculo.COMUNICANDO)
            {
                string mensaje = "El dron no se puede comunicar";
                Console.WriteLine(mensaje);
                this.estado = EstadoVehiculo.COMUNICANDO;
            }
            else 
            {
                Console.WriteLine("Conectale un microfono");
            }
        } 
        protected override void encender()
        {
            if (this.estado == EstadoVehiculo.APAGADO)
            {
                Console.WriteLine("Se encenderá el vehiculo");
                this.estado = EstadoVehiculo.ENCENDIDO;
            }
            else
            {
                Console.WriteLine("apaga el vehiculo");
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
            Console.WriteLine("No tiene forma de comunicarse");
        }
        public string ToString()
        {
            return $"Este Dron utiliza de combustible {this.combustible}, {this.llantas} tiene" +
            $" llantas, su capacidad es {this.capacidad}, tiene un estado {this.estado}";
        }

    }//Llave que cierra la clase

}//Llave que cierra el namespace

