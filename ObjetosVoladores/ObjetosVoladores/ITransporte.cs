using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public interface ITransporte
    {
        bool carga();
        bool descarga();
    }
}
