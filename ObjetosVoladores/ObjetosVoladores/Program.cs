using System;

namespace ObjetosVoladores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Crearemos un objetos. 
            Console.WriteLine("Instanciando 3 Drones");
            Dron dron1 = new Dron();
            Dron dron2 = new Dron();
            Dron dron3 = new Dron();
            //Estamos encendiendo los drones
            dron1.Encender();
            //Aquí creamos los drones e imprimimos
            Console.WriteLine(dron1.ToString());
            Console.WriteLine(dron2.ToString());
            Console.WriteLine(dron3.ToString());
            Console.ReadKey();
        }
    }
}