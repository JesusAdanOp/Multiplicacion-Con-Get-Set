using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_Con_Get_Set
{
    internal class clmultiplicacion
    {
        int v1, v2;

        public int V1
        {
            get { return v1; }
            set { v1 = value; }
        }
        public int V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public int multiplicar()
        {
            return v1*v2;
        }
    }
}
