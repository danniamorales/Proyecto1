using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_2022
{
    class Poder_del_equipo
    {
        public static double calcularpoder4final(double P_G, double P_P, double P_E)
        {

            double poder = ((P_G * 0.7) - (P_P * 0.2) + (P_E * 0.1)) / 4;
            poder = Math.Round(poder, 3);

            return poder;

        }

        public static double calcularpodersemi(double P_G, double P_P, double P_E)
        {
            double poder = ((P_G * 0.7) - (P_P * 0.2) + (P_E * 0.1)) / 5;
            poder = Math.Round(poder, 3);

            return poder;

        }

        public static double calcularpoderfinal(double P_G, double P_P, double P_E)
        {
            double poder = ((P_G * 0.7) - (P_P * 0.2) + (P_E * 0.1)) / 6;
            poder = Math.Round(poder, 3);

            return poder;
        }
    }
}
