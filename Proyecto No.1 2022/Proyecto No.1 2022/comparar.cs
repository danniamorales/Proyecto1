using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_2022
{
    class comparar
    {
        
        public static double comparacion (double x, double y)          
        {
            int caso=0;

            if (x>y)
            {
                caso = 1;
            }

            if(x<y)
            {
                caso = 2;
            }

            if (x==y)
            {
                caso = 3;
            }

            return caso;

        }
    }
}
