using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public interface IVolador
    {
        void despegar();
        void aterrizar();
        
        string volar(int tiempo);
    }

}
