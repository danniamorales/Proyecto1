using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_2022
{
    class Partido
    {
        public static double simulacion1(double x)
        {
            int a = 0;
            for (int i = 1; i < 6; i++)
            {
                Random ran = new Random();
                double numerorandom = ran.NextDouble();

                if (numerorandom < x)
                {
                    a++;
                }
            }
            return a;

        }

        public static double simulacion2(double x)
        {
            int a = 0;
            for (int i = 1; i < 6; i++)
            {
                Random ran = new Random();
                double numerorandom = ran.NextDouble();

                if (numerorandom < x)
                {
                    a++;              

                }
            }
            return a;

        }


    }
}
