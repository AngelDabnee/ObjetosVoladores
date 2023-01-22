using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public class AvionCarga : Avion, ITransporte
    {
        public AvionCarga()
        {
            Console.WriteLine("Estamos creando un nuevo avion de carga");
            this.estado = EstadoVehiculo.ENCENDIDO;
            this.combustible = "Requiere JET A";
            this.llantas = 7;
            this.capacidad = 80000;

        }

        public bool carga()
        {
            Console.WriteLine("Este avión no transporta personas");
            return false;
        }

        public bool descarga()
        {
            Console.WriteLine("Este avión si se utiliza para descargar cosas");
            return true;
        }
        public string ToString()
        {
            return $"El avión esta {this.estado} por lo cual iniciamos las operaciones, este necesita " +
                $"{this.combustible} tiene un total de {this.llantas} tiene una capacidad de {this.capacidad} de kg, promedio. ";
        }
    }
}
