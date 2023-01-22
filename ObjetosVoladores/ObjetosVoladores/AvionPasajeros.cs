using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public class AvionPasajeros : Avion, ITransporte
    {
        public AvionPasajeros()
        {
            Console.WriteLine("Estamos creando un nuevo avion de carga de pasajeros");
            this.estado = EstadoVehiculo.APAGADO;
            this.combustible = "Requiere JET A";
            this.llantas = 15;
            this.capacidad = 410012;

        }

        public bool carga()
        {
            Console.WriteLine("Este avión está listo para llevar personas");
            return true;
        }

        public bool descarga()
        {
            Console.WriteLine("El procecso de descarga se inicia al momento de estar apagado y en la zona de aterrizaje");
            return true;
        }
        public string ToString()
        {
            return $"El avión esta {this.estado} por lo cual iniciamos las operaciones, este necesita " +
                $"{this.combustible} tiene un total de {this.llantas} tiene una capacidad de {this.capacidad} de kg, promedio. ";
        }
    }
}
