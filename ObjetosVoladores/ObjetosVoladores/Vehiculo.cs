using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public abstract class Vehiculo
    {
        //Definimos propiedades
        protected string combustible;
        protected int llantas;
        protected double capacidad;
        protected EstadoVehiculo estado;

        //MÉTODOS ABSTRACTOS
        protected abstract void comunicar(string msg);
        protected abstract void encender();
        protected abstract void apagar();

        public Vehiculo()
        {
        }
        public enum EstadoVehiculo
        {
            APAGADO,
            ENCENDIDO,
            DETENIDO,
            EN_TRANSITO,
            DESPEGANDO,
            ATERRIZANDO,

        }
    }
} //Terminamos la clase ABSTRACTA
