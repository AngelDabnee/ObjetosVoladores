using System;

namespace ObjetosVoladores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Crearemos un objetos. 
            Console.WriteLine("Instanciando 1 Dron");
            Dron dron1 = new Dron();
            //Estamos encendiendo los drones
            dron1.Encender();
            //Aquí creamos los drones e imprimimos
            Console.WriteLine(dron1.ToString());
            dron1.Comunicar();
            dron1.Apagar();
            //Programación del AVION
            //Creando el avión. 
            Console.WriteLine("Ahora daremos las instrucciónes para un avión.");
            Avion avion1 = new Avion();
            //Encenderemos el avión. 
            avion1.Encender();
            avion1.volar(1);
            avion1.Comunicar();
            avion1.aterrizar();
            avion1.Apagar();
            Console.WriteLine(avion1.ToString());
            //Iniciaremos con la programación el helicoptero. 
            //Creando un helicoptero
            Console.WriteLine("Daremos las instrucciones para programar un helicoptero");
            Helicoptero helicoptero1 = new Helicoptero();
            helicoptero1.Encender();
            helicoptero1.despegar();
            helicoptero1.volar(1);
            helicoptero1.Comunicar();
            helicoptero1.aterrizar();
            Console.WriteLine(helicoptero1.ToString());
            //Iniciamos con la creación de un avión de carga de pasajeros. 
            Console.WriteLine("Daremos las especificaciones de un Avion de Pasajeros");
            AvionPasajeros avionPasajeros = new AvionPasajeros();
            avionPasajeros.Encender();
            avionPasajeros.despegar();
            avionPasajeros.volar(1);
            avionPasajeros.aterrizar();
            avionPasajeros.Comunicar();
            avionPasajeros.carga();
            Console.WriteLine(avionPasajeros.ToString());
            //Iniciamos con el avión de carga
            Console.WriteLine("DAremos las especificaciones para un Avión de carga");
            AvionCarga avionCarga = new AvionCarga();
            avionCarga.carga();
            avionCarga.Encender();
            avionCarga.descarga();
            avionCarga.volar(1);
            avionCarga.aterrizar();
            avionCarga.Comunicar();
            Console.WriteLine(avionCarga.ToString());
        }
    }
}