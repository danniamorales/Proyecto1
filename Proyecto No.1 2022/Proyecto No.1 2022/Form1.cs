using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_No._1_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Equipo equipo1 = new Equipo();
            this.textBox1.MaxLength = 100;
            equipo1.nombre = textBox1.Text;
            equipo1.PG = int.Parse(textBox9.Text);
            equipo1.PP = int.Parse(textBox10.Text);
            equipo1.PE = int.Parse(textBox11.Text);
            /*equipo1.TP = equipo1.PG + equipo1.PP + equipo1.PE;
            equipo1.Llave = 1;*/

            Equipo equipo2 = new Equipo();
            this.textBox2.MaxLength = 100;
            equipo2.nombre = textBox2.Text;
            equipo2.PG = int.Parse(textBox12.Text);
            equipo2.PP = int.Parse(textBox13.Text);
            equipo2.PE = int.Parse(textBox14.Text);
            /*equipo2.TP = equipo2.PG + equipo2.PP + equipo2.PE;
            equipo2.Llave = 3;*/

            Equipo equipo3 = new Equipo();
            this.textBox3.MaxLength = 100;
            equipo3.nombre = textBox3.Text;
            equipo3.PG = int.Parse(textBox15.Text);
            equipo3.PP = int.Parse(textBox16.Text);
            equipo3.PE = int.Parse(textBox17.Text);
            /*equipo3.TP = equipo3.PG + equipo3.PP + equipo3.PE;
            equipo3.Llave = 5;*/

            Equipo equipo4 = new Equipo();
            this.textBox4.MaxLength = 100;
            equipo4.nombre = textBox4.Text;
            equipo4.PG = int.Parse(textBox18.Text);
            equipo4.PP = int.Parse(textBox19.Text);
            equipo4.PE = int.Parse(textBox20.Text);
            /*equipo4.TP = equipo4.PG + equipo4.PP + equipo4.PE;
            equipo4.Llave = 7;*/

            Equipo equipo5 = new Equipo();
            this.textBox5.MaxLength = 100;
            equipo5.nombre = textBox5.Text;
            equipo5.PG = int.Parse(textBox21.Text);
            equipo5.PP = int.Parse(textBox22.Text);
            equipo5.PE = int.Parse(textBox23.Text);
            /*equipo5.TP = equipo5.PG + equipo5.PP + equipo5.PE;*/

            Equipo equipo6 = new Equipo();
            this.textBox6.MaxLength = 100;
            equipo6.nombre = textBox6.Text;
            equipo6.PG = int.Parse(textBox24.Text);
            equipo6.PP = int.Parse(textBox25.Text);
            equipo6.PE = int.Parse(textBox26.Text);
            /*equipo6.TP = equipo6.PG + equipo6.PP + equipo6.PE;*/

            Equipo equipo7 = new Equipo();
            this.textBox7.MaxLength = 100;
            equipo7.nombre = textBox7.Text;
            equipo7.PG = int.Parse(textBox27.Text);
            equipo7.PP = int.Parse(textBox28.Text);
            equipo7.PE = int.Parse(textBox29.Text);
            /*equipo7.TP = equipo7.PG + equipo7.PP + equipo7.PE;*/

            Equipo equipo8 = new Equipo();
            this.textBox8.MaxLength = 100;
            equipo8.nombre = textBox8.Text;
            equipo8.PG = int.Parse(textBox30.Text);
            equipo8.PP = int.Parse(textBox31.Text);
            equipo8.PE = int.Parse(textBox32.Text);
            /*equipo8.TP = equipo8.PG + equipo8.PP + equipo8.PE;*/

            textBox33.Text = equipo1.nombre;
            textBox34.Text = equipo2.nombre;
            textBox35.Text = equipo3.nombre;
            textBox36.Text = equipo4.nombre;
            textBox37.Text = equipo5.nombre;
            textBox38.Text = equipo6.nombre;
            textBox39.Text = equipo7.nombre;
            textBox40.Text = equipo8.nombre;



            equipo1.poderf1 = Poder_del_equipo.calcularpoder4final(equipo1.PG, equipo1.PP, equipo1.PE);
            equipo2.poderf1 = Poder_del_equipo.calcularpoder4final(equipo2.PG, equipo2.PP, equipo2.PE);
            equipo3.poderf1 = Poder_del_equipo.calcularpoder4final(equipo3.PG, equipo3.PP, equipo3.PE);
            equipo4.poderf1 = Poder_del_equipo.calcularpoder4final(equipo4.PG, equipo4.PP, equipo4.PE);
            equipo5.poderf1 = Poder_del_equipo.calcularpoder4final(equipo5.PG, equipo5.PP, equipo5.PE);
            equipo6.poderf1 = Poder_del_equipo.calcularpoder4final(equipo6.PG, equipo6.PP, equipo6.PE);
            equipo7.poderf1 = Poder_del_equipo.calcularpoder4final(equipo7.PG, equipo7.PP, equipo7.PE);
            equipo8.poderf1 = Poder_del_equipo.calcularpoder4final(equipo8.PG, equipo8.PP, equipo8.PE);


            equipo1.GolesA = Partido.simulacion1(equipo1.poderf1);
            equipo2.GolesA = Partido.simulacion2(equipo2.poderf1);
            equipo3.GolesA = Partido.simulacion1(equipo3.poderf1);
            equipo4.GolesA = Partido.simulacion2(equipo4.poderf1);
            equipo5.GolesA = Partido.simulacion1(equipo5.poderf1);
            equipo6.GolesA = Partido.simulacion2(equipo6.poderf1);
            equipo7.GolesA = Partido.simulacion1(equipo7.poderf1);
            equipo8.GolesA = Partido.simulacion2(equipo8.poderf1);

            if (comparar.comparacion(equipo1.GolesA, equipo2.GolesA) == 1)
            {
                textBox41.Text = equipo1.nombre;
                equipo2.GolesR = equipo1.GolesA;
                equipo1.etapa++;
            }
            if (comparar.comparacion(equipo1.GolesA, equipo2.GolesA) == 2)
            {
                textBox41.Text = equipo2.nombre;
                equipo1.GolesR = equipo2.GolesA;
                equipo2.etapa++;
            }
            if (comparar.comparacion(equipo1.GolesA, equipo2.GolesA) == 3)
            {
                do
                {
                    equipo1.GolesA = Partido.simulacion1(equipo1.poderf1);
                    equipo2.GolesA = Partido.simulacion2(equipo2.poderf1);


                } while (equipo1.GolesA == equipo2.GolesA);

                if (comparar.comparacion(equipo1.GolesA, equipo2.GolesA) == 1)
                {
                    textBox41.Text = equipo1.nombre;
                    equipo2.GolesR = equipo1.GolesA;
                    equipo1.etapa++;
                }

                if (comparar.comparacion(equipo1.GolesA, equipo2.GolesA) == 2)
                {
                    textBox41.Text = equipo2.nombre;
                    equipo1.GolesR = equipo2.GolesA;
                    equipo2.etapa++;
                }
            }

            textBox47.Text = equipo1.GolesA.ToString();
            textBox48.Text = equipo2.GolesA.ToString();

            if (comparar.comparacion(equipo3.GolesA, equipo3.GolesA) == 1)
            {
                textBox42.Text = equipo3.nombre;
                equipo3.GolesR = equipo4.GolesA;
                equipo3.etapa++;
            }
            if (comparar.comparacion(equipo3.GolesA, equipo4.GolesA) == 2)
            {
                textBox42.Text = equipo4.nombre;
                equipo4.GolesR = equipo3.GolesA;
                equipo4.etapa++;
            }
            if (comparar.comparacion(equipo3.GolesA, equipo4.GolesA) == 3)
            {
                do
                {
                    equipo3.GolesA = Partido.simulacion1(equipo3.poderf1);
                    equipo4.GolesA = Partido.simulacion2(equipo4.poderf1);


                } while (equipo3.GolesA == equipo4.GolesA);
                if (comparar.comparacion(equipo3.GolesA, equipo4.GolesA) == 1)
                {
                    textBox42.Text = equipo3.nombre;
                    equipo3.GolesR = equipo4.GolesA;
                    equipo3.etapa++;
                }
                if (comparar.comparacion(equipo3.GolesA, equipo4.GolesA) == 2)
                {
                    textBox42.Text = equipo4.nombre;
                    equipo4.GolesR = equipo3.GolesA;
                    equipo4.etapa++;
                }
            }

            textBox49.Text = equipo3.GolesA.ToString();
            textBox50.Text = equipo4.GolesA.ToString();

            if (comparar.comparacion(equipo5.GolesA, equipo6.GolesA) == 1)
            {
                textBox43.Text = equipo5.nombre;
                equipo5.GolesR = equipo6.GolesA;
                equipo5.etapa++;
            }
            if (comparar.comparacion(equipo5.GolesA, equipo6.GolesA) == 2)
            {
                textBox43.Text = equipo6.nombre;
                equipo6.GolesR = equipo5.GolesA;
                equipo6.etapa++;
            }
            if (comparar.comparacion(equipo5.GolesA, equipo6.GolesA) == 3)
            {
                do
                {
                    equipo5.GolesA = Partido.simulacion1(equipo5.poderf1);
                    equipo6.GolesA = Partido.simulacion2(equipo6.poderf1);
                } while (equipo5.GolesA == equipo6.GolesA);

                if (comparar.comparacion(equipo5.GolesA, equipo6.GolesA) == 1)
                {
                    textBox43.Text = equipo5.nombre;
                    equipo5.GolesR = equipo6.GolesA;
                    equipo5.etapa++;
                }
                if (comparar.comparacion(equipo5.GolesA, equipo6.GolesA) == 2)
                {
                    textBox43.Text = equipo6.nombre;
                    equipo6.GolesR = equipo5.GolesA;
                    equipo6.etapa++;
                }
            }

            textBox51.Text = equipo5.GolesA.ToString();
            textBox52.Text = equipo6.GolesA.ToString();

            if (comparar.comparacion(equipo7.GolesA, equipo8.GolesA) == 1)
            {
                textBox44.Text = equipo7.nombre;
                equipo7.GolesR = equipo8.GolesA;
                equipo7.etapa++;
            }
            if (comparar.comparacion(equipo7.GolesA, equipo8.GolesA) == 2)
            {
                textBox44.Text = equipo8.nombre;
                equipo8.GolesR = equipo7.GolesA;
                equipo8.etapa++;
            }
            if (comparar.comparacion(equipo7.GolesA, equipo8.GolesA) == 3)
            {
                do
                {
                    equipo7.GolesA = Partido.simulacion1(equipo7.poderf1);
                    equipo8.GolesA = Partido.simulacion2(equipo8.poderf1);


                } while (equipo7.GolesA == equipo8.GolesA);
                if (comparar.comparacion(equipo7.GolesA, equipo8.GolesA) == 1)
                {
                    textBox44.Text = equipo7.nombre;
                    equipo7.GolesR = equipo8.GolesA;
                    equipo7.etapa++;
                }
                if (comparar.comparacion(equipo7.GolesA, equipo8.GolesA) == 2)
                {
                    textBox41.Text = equipo8.nombre;
                    equipo8.GolesR = equipo7.GolesA;
                    equipo8.etapa++;
                }

            }

            textBox53.Text = equipo7.GolesA.ToString();
            textBox54.Text = equipo8.GolesA.ToString();



            //SEMIFINALES
            equipo1.poderf2 = Poder_del_equipo.calcularpodersemi(equipo1.PG, equipo1.PP, equipo1.PE);
            equipo2.poderf2 = Poder_del_equipo.calcularpodersemi(equipo2.PG, equipo2.PP, equipo2.PE);
            equipo3.poderf2 = Poder_del_equipo.calcularpodersemi(equipo3.PG, equipo3.PP, equipo3.PE);
            equipo4.poderf2 = Poder_del_equipo.calcularpodersemi(equipo4.PG, equipo4.PP, equipo4.PE);
            equipo5.poderf2 = Poder_del_equipo.calcularpodersemi(equipo5.PG, equipo5.PP, equipo5.PE);
            equipo6.poderf2 = Poder_del_equipo.calcularpodersemi(equipo6.PG, equipo6.PP, equipo6.PE);
            equipo7.poderf2 = Poder_del_equipo.calcularpodersemi(equipo7.PG, equipo7.PP, equipo7.PE);
            equipo8.poderf2 = Poder_del_equipo.calcularpodersemi(equipo8.PG, equipo8.PP, equipo8.PE);



            if (equipo1.etapa == 1)
            {
                if (equipo1.etapa == equipo3.etapa)
                {
                    equipo1.GolesA = Partido.simulacion1(equipo1.poderf2);
                    equipo3.GolesA = Partido.simulacion1(equipo3.poderf2);

                    if (comparar.comparacion(equipo1.GolesA, equipo3.GolesA) == 1)
                    {
                        textBox45.Text = equipo1.nombre;
                        equipo1.etapa++;
                    }

                    if (comparar.comparacion(equipo1.GolesA, equipo3.GolesA) == 2)
                    {
                        textBox45.Text = equipo3.nombre;
                        equipo3.etapa++;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo3.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf2);
                            equipo3.GolesA = Partido.simulacion2(equipo3.poderf2);


                        } while (equipo1.GolesA == equipo3.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo3.GolesA) == 1)
                        {
                            textBox45.Text = equipo1.nombre;
                            equipo1.etapa++;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo3.GolesA) == 2)
                        {
                            textBox45.Text = equipo3.nombre;
                            equipo3.etapa++;
                        }
                    }
                    equipo1.GolesR = equipo3.GolesA;
                    equipo3.GolesR = equipo1.GolesA;
                    textBox55.Text = equipo1.GolesA.ToString();
                    textBox56.Text = equipo3.GolesA.ToString();


                }

                if (equipo1.etapa == equipo4.etapa)
                {
                    equipo1.GolesA = Partido.simulacion1(equipo1.poderf2);
                    equipo4.GolesA = Partido.simulacion1(equipo4.poderf2);

                    if (comparar.comparacion(equipo1.GolesA, equipo4.GolesA) == 1)
                    {
                        textBox45.Text = equipo1.nombre;
                        equipo1.etapa++;
                    }

                    if (comparar.comparacion(equipo1.GolesA, equipo4.GolesA) == 2)
                    {
                        textBox45.Text = equipo4.nombre;
                        equipo4.etapa++;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo4.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf2);
                            equipo4.GolesA = Partido.simulacion2(equipo4.poderf2);


                        } while (equipo1.GolesA == equipo4.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo4.GolesA) == 1)
                        {
                            textBox45.Text = equipo1.nombre;
                            equipo1.etapa++;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo4.GolesA) == 2)
                        {
                            textBox45.Text = equipo4.nombre;
                            equipo4.etapa++;
                        }
                    }
                    equipo1.GolesR = equipo4.GolesA;
                    equipo4.GolesR = equipo1.GolesA;
                    textBox55.Text = equipo1.GolesA.ToString();
                    textBox56.Text = equipo4.GolesA.ToString();



                }
            }

            if (equipo2.etapa == 1)
            {
                if (equipo2.etapa == equipo3.etapa)
                {
                    equipo2.GolesA = Partido.simulacion1(equipo2.poderf2);
                    equipo3.GolesA = Partido.simulacion1(equipo3.poderf2);

                    if (comparar.comparacion(equipo2.GolesA, equipo3.GolesA) == 1)
                    {
                        textBox45.Text = equipo2.nombre;
                        equipo2.etapa++;
                    }

                    if (comparar.comparacion(equipo2.GolesA, equipo3.GolesA) == 2)
                    {
                        textBox45.Text = equipo3.nombre;
                        equipo3.etapa++;
                    }
                    if (comparar.comparacion(equipo2.GolesA, equipo3.GolesA) == 3)
                    {
                        do
                        {
                            equipo2.GolesA = Partido.simulacion1(equipo2.poderf2);
                            equipo3.GolesA = Partido.simulacion2(equipo3.poderf2);


                        } while (equipo2.GolesA == equipo3.GolesA);

                        if (comparar.comparacion(equipo2.GolesA, equipo3.GolesA) == 1)
                        {
                            textBox45.Text = equipo2.nombre;
                            equipo2.etapa++;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo3.GolesA) == 2)
                        {
                            textBox45.Text = equipo3.nombre;
                            equipo3.etapa++;
                        }
                    }
                    equipo2.GolesR = equipo3.GolesA;
                    equipo3.GolesR = equipo2.GolesA;
                    textBox55.Text = equipo2.GolesA.ToString();
                    textBox56.Text = equipo3.GolesA.ToString();


                }

                if (equipo2.etapa == equipo4.etapa)
                {
                    equipo2.GolesA = Partido.simulacion1(equipo1.poderf2);
                    equipo4.GolesA = Partido.simulacion1(equipo4.poderf2);

                    if (comparar.comparacion(equipo2.GolesA, equipo4.GolesA) == 1)
                    {
                        textBox45.Text = equipo2.nombre;
                        equipo2.etapa++;
                    }

                    if (comparar.comparacion(equipo2.GolesA, equipo4.GolesA) == 2)
                    {
                        textBox45.Text = equipo4.nombre;
                        equipo4.etapa++;
                    }
                    if (comparar.comparacion(equipo2.GolesA, equipo4.GolesA) == 3)
                    {
                        do
                        {
                            equipo2.GolesA = Partido.simulacion1(equipo2.poderf2);
                            equipo4.GolesA = Partido.simulacion2(equipo4.poderf2);


                        } while (equipo2.GolesA == equipo4.GolesA);

                        if (comparar.comparacion(equipo2.GolesA, equipo4.GolesA) == 1)
                        {
                            textBox45.Text = equipo2.nombre;
                            equipo2.etapa++;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo4.GolesA) == 2)
                        {
                            textBox45.Text = equipo4.nombre;
                            equipo4.etapa++;
                        }
                    }
                    equipo2.GolesR = equipo4.GolesA;
                    equipo4.GolesR = equipo2.GolesA;
                    textBox55.Text = equipo2.GolesA.ToString();
                    textBox56.Text = equipo4.GolesA.ToString();

                }
            }

            if (equipo5.etapa == 1) //1 PASA A SER 5 Y 3 PASA A SER 7
            {
                if (equipo5.etapa == equipo7.etapa)
                {
                    equipo5.GolesA = Partido.simulacion1(equipo5.poderf2);
                    equipo7.GolesA = Partido.simulacion2(equipo7.poderf2);

                    if (comparar.comparacion(equipo5.GolesA, equipo7.GolesA) == 1)
                    {
                        textBox46.Text = equipo5.nombre;
                        equipo5.etapa++;
                    }

                    if (comparar.comparacion(equipo5.GolesA, equipo7.GolesA) == 2)
                    {
                        textBox46.Text = equipo7.nombre;
                        equipo7.etapa++;
                    }
                    if (comparar.comparacion(equipo5.GolesA, equipo7.GolesA) == 3)
                    {
                        do
                        {
                            equipo5.GolesA = Partido.simulacion1(equipo5.poderf2);
                            equipo7.GolesA = Partido.simulacion2(equipo7.poderf2);


                        } while (equipo5.GolesA == equipo7.GolesA);

                        if (comparar.comparacion(equipo5.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox46.Text = equipo5.nombre;
                            equipo5.etapa++;
                        }

                        if (comparar.comparacion(equipo5.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox46.Text = equipo7.nombre;
                            equipo7.etapa++;
                        }
                    }
                    equipo5.GolesR = equipo7.GolesA;
                    equipo7.GolesR = equipo5.GolesA;
                    textBox57.Text = equipo5.GolesA.ToString();
                    textBox58.Text = equipo7.GolesA.ToString();
                }

                if (equipo5.etapa == equipo8.etapa)
                {
                    equipo5.GolesA = Partido.simulacion1(equipo5.poderf2);
                    equipo8.GolesA = Partido.simulacion1(equipo8.poderf2);

                    if (comparar.comparacion(equipo5.GolesA, equipo8.GolesA) == 1)
                    {
                        textBox46.Text = equipo5.nombre;
                        equipo1.etapa++;
                    }

                    if (comparar.comparacion(equipo5.GolesA, equipo8.GolesA) == 2)
                    {
                        textBox46.Text = equipo8.nombre;
                        equipo8.etapa++;
                    }
                    if (comparar.comparacion(equipo5.GolesA, equipo8.GolesA) == 3)
                    {
                        do
                        {
                            equipo5.GolesA = Partido.simulacion1(equipo5.poderf2);
                            equipo8.GolesA = Partido.simulacion2(equipo8.poderf2);


                        } while (equipo5.GolesA == equipo8.GolesA);

                        if (comparar.comparacion(equipo5.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox46.Text = equipo5.nombre;
                            equipo5.etapa++;
                        }

                        if (comparar.comparacion(equipo5.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox46.Text = equipo8.nombre;
                            equipo8.etapa++;
                        }
                    }
                    equipo5.GolesR = equipo8.GolesA;
                    equipo8.GolesR = equipo5.GolesA;
                    textBox57.Text = equipo5.GolesA.ToString();
                    textBox58.Text = equipo8.GolesA.ToString();
                }


            }

            if (equipo6.etapa == 1)
            {
                if (equipo6.etapa == equipo7.etapa)
                {
                    equipo6.GolesA = Partido.simulacion1(equipo6.poderf2);
                    equipo7.GolesA = Partido.simulacion2(equipo7.poderf2);

                    if (comparar.comparacion(equipo6.GolesA, equipo7.GolesA) == 1)
                    {
                        textBox46.Text = equipo6.nombre;
                        equipo6.etapa++;
                    }

                    if (comparar.comparacion(equipo6.GolesA, equipo7.GolesA) == 2)
                    {
                        textBox46.Text = equipo7.nombre;
                        equipo7.etapa++;
                    }
                    if (comparar.comparacion(equipo6.GolesA, equipo7.GolesA) == 3)
                    {
                        do
                        {
                            equipo6.GolesA = Partido.simulacion1(equipo6.poderf2);
                            equipo7.GolesA = Partido.simulacion2(equipo7.poderf2);


                        } while (equipo6.GolesA == equipo7.GolesA);

                        if (comparar.comparacion(equipo6.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox46.Text = equipo6.nombre;
                            equipo6.etapa++;
                        }

                        if (comparar.comparacion(equipo6.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox46.Text = equipo7.nombre;
                            equipo7.etapa++;
                        }
                    }
                    equipo6.GolesR = equipo7.GolesA;
                    equipo7.GolesR = equipo6.GolesA;
                    textBox57.Text = equipo5.GolesA.ToString();
                    textBox58.Text = equipo7.GolesA.ToString();
                }

                if (equipo6.etapa == equipo8.etapa)
                {
                    equipo6.GolesA = Partido.simulacion1(equipo6.poderf2);
                    equipo8.GolesA = Partido.simulacion1(equipo8.poderf2);

                    if (comparar.comparacion(equipo6.GolesA, equipo8.GolesA) == 1)
                    {
                        textBox46.Text = equipo6.nombre;
                        equipo6.etapa++;
                    }

                    if (comparar.comparacion(equipo6.GolesA, equipo8.GolesA) == 2)
                    {
                        textBox46.Text = equipo8.nombre;
                        equipo8.etapa++;
                    }
                    if (comparar.comparacion(equipo6.GolesA, equipo8.GolesA) == 3)
                    {
                        do
                        {
                            equipo6.GolesA = Partido.simulacion1(equipo6.poderf2);
                            equipo8.GolesA = Partido.simulacion2(equipo8.poderf2);


                        } while (equipo6.GolesA == equipo8.GolesA);

                        if (comparar.comparacion(equipo6.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox46.Text = equipo6.nombre;
                            equipo6.etapa++;
                        }

                        if (comparar.comparacion(equipo6.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox46.Text = equipo8.nombre;
                            equipo8.etapa++;
                        }
                    }
                    equipo6.GolesR = equipo8.GolesA;
                    equipo8.GolesR = equipo6.GolesA;
                    textBox57.Text = equipo6.GolesA.ToString();
                    textBox58.Text = equipo8.GolesA.ToString();
                }
            }
            // FFFFIIIIIINNNNNNAAAAAALLLL

            equipo1.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo1.PG, equipo1.PP, equipo1.PE);
            equipo2.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo2.PG, equipo2.PP, equipo2.PE);
            equipo3.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo3.PG, equipo3.PP, equipo3.PE);
            equipo4.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo4.PG, equipo4.PP, equipo4.PE);
            equipo5.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo5.PG, equipo5.PP, equipo5.PE);
            equipo6.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo6.PG, equipo6.PP, equipo6.PE);
            equipo7.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo7.PG, equipo7.PP, equipo7.PE);
            equipo8.poderf3 = Poder_del_equipo.calcularpoderfinal(equipo8.PG, equipo8.PP, equipo8.PE);

            equipo1.GolesA = Partido.simulacion1(equipo1.poderf3);
            equipo2.GolesA = Partido.simulacion2(equipo2.poderf3);
            equipo3.GolesA = Partido.simulacion1(equipo3.poderf3);
            equipo4.GolesA = Partido.simulacion2(equipo4.poderf3);
            equipo5.GolesA = Partido.simulacion1(equipo5.poderf3);
            equipo6.GolesA = Partido.simulacion2(equipo6.poderf3);
            equipo7.GolesA = Partido.simulacion1(equipo7.poderf3);
            equipo8.GolesA = Partido.simulacion2(equipo8.poderf3);

            //111111111111111111111111111111111111111111111111111111111
            if (equipo1.etapa == 2)
            {
                if (equipo1.etapa == equipo5.etapa)
                {

                    if (comparar.comparacion(equipo1.GolesA, equipo5.GolesA) == 1)
                    {
                        textBox61.Text = equipo1.nombre;

                    }

                    if (comparar.comparacion(equipo1.GolesA, equipo5.GolesA) == 2)
                    {
                        textBox61.Text = equipo5.nombre;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo5.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf3);
                            equipo5.GolesA = Partido.simulacion2(equipo5.poderf3);


                        } while (equipo1.GolesA == equipo5.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo5.GolesA) == 1)
                        {
                            textBox61.Text = equipo1.nombre;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo5.GolesA) == 2)
                        {
                            textBox61.Text = equipo5.nombre;
                            equipo5.etapa++;
                        }
                    }
                    equipo1.GolesR = equipo5.GolesA;
                    equipo5.GolesR = equipo1.GolesA;
                    textBox59.Text = equipo1.GolesA.ToString();
                    textBox60.Text = equipo5.GolesA.ToString();
                }
                if (equipo1.etapa == equipo6.etapa)
                {
                    if (comparar.comparacion(equipo1.GolesA, equipo6.GolesA) == 1)
                    {
                        textBox61.Text = equipo1.nombre;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo6.GolesA) == 2)
                    {
                        textBox61.Text = equipo6.nombre;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo6.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf3);
                            equipo6.GolesA = Partido.simulacion2(equipo6.poderf3);


                        } while (equipo1.GolesA == equipo6.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo6.GolesA) == 1)
                        {
                            textBox61.Text = equipo1.nombre;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo6.GolesA) == 2)
                        {
                            textBox61.Text = equipo6.nombre;
                            equipo6.etapa++;
                        }
                    }
                    equipo1.GolesR = equipo6.GolesA;
                    equipo6.GolesR = equipo1.GolesA;
                    textBox59.Text = equipo1.GolesA.ToString();
                    textBox60.Text = equipo6.GolesA.ToString();
                }
                if (equipo1.etapa == equipo7.etapa)
                {
                    if (comparar.comparacion(equipo1.GolesA, equipo7.GolesA) == 1)
                    {
                        textBox61.Text = equipo1.nombre;

                    }

                    if (comparar.comparacion(equipo1.GolesA, equipo7.GolesA) == 2)
                    {
                        textBox61.Text = equipo7.nombre;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo7.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf3);
                            equipo7.GolesA = Partido.simulacion2(equipo7.poderf3);


                        } while (equipo1.GolesA == equipo7.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox61.Text = equipo1.nombre;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox61.Text = equipo7.nombre;

                        }
                    }
                    equipo1.GolesR = equipo7.GolesA;
                    equipo7.GolesR = equipo1.GolesA;
                    textBox59.Text = equipo1.GolesA.ToString();
                    textBox60.Text = equipo7.GolesA.ToString();

                }
                if (equipo1.etapa == equipo8.etapa)
                {
                    if (comparar.comparacion(equipo1.GolesA, equipo8.GolesA) == 1)
                    {
                        textBox61.Text = equipo1.nombre;

                    }

                    if (comparar.comparacion(equipo1.GolesA, equipo8.GolesA) == 2)
                    {
                        textBox61.Text = equipo8.nombre;
                    }
                    if (comparar.comparacion(equipo1.GolesA, equipo8.GolesA) == 3)
                    {
                        do
                        {
                            equipo1.GolesA = Partido.simulacion1(equipo1.poderf3);
                            equipo5.GolesA = Partido.simulacion2(equipo8.poderf3);


                        } while (equipo1.GolesA == equipo8.GolesA);

                        if (comparar.comparacion(equipo1.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox61.Text = equipo1.nombre;
                        }

                        if (comparar.comparacion(equipo1.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox61.Text = equipo8.nombre;

                        }
                    }
                    equipo1.GolesR = equipo8.GolesA;
                    equipo8.GolesR = equipo1.GolesA;
                    textBox59.Text = equipo1.GolesA.ToString();
                    textBox60.Text = equipo8.GolesA.ToString();
                }
            }
            //2222222222222222222222222222222222222222222222222222222222
            if (equipo2.etapa == 2)
            {
                if (equipo2.etapa == equipo5.etapa)
                {

                    if (comparar.comparacion(equipo2.GolesA, equipo5.GolesA) == 1)
                    {
                        textBox61.Text = equipo2.nombre;
                    }

                    if (comparar.comparacion(equipo2.GolesA, equipo5.GolesA) == 2)
                    {
                        textBox61.Text = equipo5.nombre;
                    }
                    if (comparar.comparacion(equipo2.GolesA, equipo5.GolesA) == 3)
                    {
                        do
                        {
                            equipo2.GolesA = Partido.simulacion1(equipo2.poderf3);
                            equipo5.GolesA = Partido.simulacion2(equipo5.poderf3);


                        } while (equipo2.GolesA == equipo5.GolesA);

                        if (comparar.comparacion(equipo2.GolesA, equipo5.GolesA) == 1)
                        {
                            textBox61.Text = equipo2.nombre;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo5.GolesA) == 2)
                        {
                            textBox61.Text = equipo5.nombre;
                            equipo5.etapa++;
                        }
                    }
                    equipo2.GolesR = equipo5.GolesA;
                    equipo5.GolesR = equipo2.GolesA;
                    textBox59.Text = equipo2.GolesA.ToString();
                    textBox60.Text = equipo5.GolesA.ToString();

                    if (equipo2.etapa == equipo6.etapa)
                    {
                        if (comparar.comparacion(equipo2.GolesA, equipo6.GolesA) == 1)
                        {
                            textBox61.Text = equipo2.nombre;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo6.GolesA) == 2)
                        {
                            textBox61.Text = equipo6.nombre;
                        }
                        if (comparar.comparacion(equipo2.GolesA, equipo6.GolesA) == 3)
                        {
                            do
                            {
                                equipo2.GolesA = Partido.simulacion1(equipo2.poderf3);
                                equipo6.GolesA = Partido.simulacion2(equipo6.poderf3);


                            } while (equipo2.GolesA == equipo6.GolesA);

                            if (comparar.comparacion(equipo2.GolesA, equipo6.GolesA) == 1)
                            {
                                textBox61.Text = equipo2.nombre;
                            }

                            if (comparar.comparacion(equipo2.GolesA, equipo6.GolesA) == 2)
                            {
                                textBox61.Text = equipo6.nombre;
                                equipo6.etapa++;
                            }
                        }
                        equipo2.GolesR = equipo6.GolesA;
                        equipo6.GolesR = equipo2.GolesA;
                        textBox59.Text = equipo2.GolesA.ToString();
                        textBox60.Text = equipo6.GolesA.ToString();

                    }
                    if (equipo2.etapa == equipo7.etapa)
                    {
                        if (comparar.comparacion(equipo2.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox61.Text = equipo2.nombre;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox61.Text = equipo7.nombre;
                        }
                        if (comparar.comparacion(equipo2.GolesA, equipo7.GolesA) == 3)
                        {
                            do
                            {
                                equipo2.GolesA = Partido.simulacion1(equipo2.poderf3);
                                equipo5.GolesA = Partido.simulacion2(equipo7.poderf3);


                            } while (equipo2.GolesA == equipo7.GolesA);

                            if (comparar.comparacion(equipo2.GolesA, equipo7.GolesA) == 1)
                            {
                                textBox61.Text = equipo2.nombre;
                            }

                            if (comparar.comparacion(equipo2.GolesA, equipo7.GolesA) == 2)
                            {
                                textBox61.Text = equipo7.nombre;
                                equipo7.etapa++;
                            }
                        }
                        equipo2.GolesR = equipo7.GolesA;
                        equipo7.GolesR = equipo2.GolesA;
                        textBox59.Text = equipo2.GolesA.ToString();
                        textBox60.Text = equipo7.GolesA.ToString();
                    }
                    if (equipo2.etapa == equipo8.etapa)
                    {
                        if (comparar.comparacion(equipo2.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox61.Text = equipo2.nombre;
                        }

                        if (comparar.comparacion(equipo2.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox61.Text = equipo8.nombre;
                        }
                        if (comparar.comparacion(equipo2.GolesA, equipo8.GolesA) == 3)
                        {
                            do
                            {
                                equipo2.GolesA = Partido.simulacion1(equipo2.poderf3);
                                equipo5.GolesA = Partido.simulacion2(equipo8.poderf3);


                            } while (equipo2.GolesA == equipo8.GolesA);

                            if (comparar.comparacion(equipo2.GolesA, equipo8.GolesA) == 1)
                            {
                                textBox61.Text = equipo2.nombre;
                            }

                            if (comparar.comparacion(equipo2.GolesA, equipo8.GolesA) == 2)
                            {
                                textBox61.Text = equipo8.nombre;
                            }
                        }
                        equipo2.GolesR = equipo8.GolesA;
                        equipo8.GolesR = equipo2.GolesA;
                        textBox59.Text = equipo2.GolesA.ToString();
                        textBox60.Text = equipo8.GolesA.ToString();

                    }
                }
                //33333333333333333333333333333333333333333333333333333333333333333333333333
                if (equipo3.etapa == 2)
                {
                    if (equipo3.etapa == equipo5.etapa)
                    {
                        if (comparar.comparacion(equipo3.GolesA, equipo5.GolesA) == 1)
                        {
                            textBox61.Text = equipo3.nombre;
                        }

                        if (comparar.comparacion(equipo3.GolesA, equipo5.GolesA) == 2)
                        {
                            textBox61.Text = equipo5.nombre;
                        }
                        if (comparar.comparacion(equipo3.GolesA, equipo5.GolesA) == 3)
                        {
                            do
                            {
                                equipo3.GolesA = Partido.simulacion1(equipo3.poderf3);
                                equipo5.GolesA = Partido.simulacion2(equipo5.poderf3);
                            } while (equipo3.GolesA == equipo5.GolesA);

                            if (comparar.comparacion(equipo3.GolesA, equipo5.GolesA) == 1)
                            {
                                textBox61.Text = equipo3.nombre;
                            }

                            if (comparar.comparacion(equipo3.GolesA, equipo5.GolesA) == 2)
                            {
                                textBox61.Text = equipo5.nombre;
                                equipo5.etapa++;
                            }
                        }
                        equipo3.GolesR = equipo5.GolesA;
                        equipo5.GolesR = equipo3.GolesA;
                        textBox59.Text = equipo3.GolesA.ToString();
                        textBox60.Text = equipo5.GolesA.ToString();
                    }
                    if (equipo3.etapa == equipo6.etapa)
                    {
                        if (comparar.comparacion(equipo3.GolesA, equipo6.GolesA) == 1)
                        {
                            textBox61.Text = equipo3.nombre;
                        }

                        if (comparar.comparacion(equipo3.GolesA, equipo6.GolesA) == 2)
                        {
                            textBox61.Text = equipo6.nombre;
                        }
                        if (comparar.comparacion(equipo3.GolesA, equipo6.GolesA) == 3)
                        {
                            do
                            {
                                equipo3.GolesA = Partido.simulacion1(equipo3.poderf3);
                                equipo6.GolesA = Partido.simulacion2(equipo6.poderf3);
                            } while (equipo3.GolesA == equipo6.GolesA);

                            if (comparar.comparacion(equipo3.GolesA, equipo6.GolesA) == 1)
                            {
                                textBox61.Text = equipo3.nombre;
                            }

                            if (comparar.comparacion(equipo3.GolesA, equipo6.GolesA) == 2)
                            {
                                textBox61.Text = equipo6.nombre;                              
                            }
                        }
                        equipo3.GolesR = equipo6.GolesA;
                        equipo6.GolesR = equipo3.GolesA;
                        textBox59.Text = equipo3.GolesA.ToString();
                        textBox60.Text = equipo6.GolesA.ToString();
                    }
                    if (equipo3.etapa == equipo7.etapa)
                    {
                        if (comparar.comparacion(equipo3.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox61.Text = equipo3.nombre;
                        }

                        if (comparar.comparacion(equipo3.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox61.Text = equipo7.nombre;
                        }
                        if (comparar.comparacion(equipo3.GolesA, equipo7.GolesA) == 3)
                        {
                            do
                            {
                                equipo3.GolesA = Partido.simulacion1(equipo3.poderf3);
                                equipo6.GolesA = Partido.simulacion2(equipo7.poderf3);
                            } while (equipo3.GolesA == equipo7.GolesA);

                            if (comparar.comparacion(equipo3.GolesA, equipo7.GolesA) == 1)
                            {
                                textBox61.Text = equipo3.nombre;
                            }

                            if (comparar.comparacion(equipo3.GolesA, equipo7.GolesA) == 2)
                            {
                                textBox61.Text = equipo7.nombre;
                            }
                        }
                        equipo3.GolesR = equipo7.GolesA;
                        equipo7.GolesR = equipo3.GolesA;
                        textBox59.Text = equipo3.GolesA.ToString();
                        textBox60.Text = equipo7.GolesA.ToString();
                    }
                    if (equipo3.etapa == equipo8.etapa)
                    {
                        if (comparar.comparacion(equipo3.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox61.Text = equipo3.nombre;
                        }

                        if (comparar.comparacion(equipo3.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox61.Text = equipo8.nombre;
                        }
                        if (comparar.comparacion(equipo3.GolesA, equipo8.GolesA) == 3)
                        {
                            do
                            {
                                equipo3.GolesA = Partido.simulacion1(equipo3.poderf3);
                                equipo6.GolesA = Partido.simulacion2(equipo8.poderf3);
                            } while (equipo3.GolesA == equipo8.GolesA);

                            if (comparar.comparacion(equipo3.GolesA, equipo8.GolesA) == 1)
                            {
                                textBox61.Text = equipo3.nombre;
                            }

                            if (comparar.comparacion(equipo3.GolesA, equipo8.GolesA) == 2)
                            {
                                textBox61.Text = equipo8.nombre;
                            }
                        }
                        equipo3.GolesR = equipo8.GolesA;
                        equipo8.GolesR = equipo3.GolesA;
                        textBox59.Text = equipo3.GolesA.ToString();
                        textBox60.Text = equipo8.GolesA.ToString();

                    }
                }
                //444444444444444444444444444444444444444444444444444444444444444444444444444444444444444
                if (equipo4.etapa == 2)
                {
                    if (equipo4.etapa == equipo5.etapa)
                    {
                        if (comparar.comparacion(equipo4.GolesA, equipo5.GolesA) == 1)
                        {
                            textBox61.Text = equipo4.nombre;
                        }

                        if (comparar.comparacion(equipo4.GolesA, equipo5.GolesA) == 2)
                        {
                            textBox61.Text = equipo5.nombre;
                        }
                        if (comparar.comparacion(equipo4.GolesA, equipo5.GolesA) == 3)
                        {
                            do
                            {
                                equipo4.GolesA = Partido.simulacion1(equipo4.poderf3);
                                equipo5.GolesA = Partido.simulacion2(equipo5.poderf3);
                            } while (equipo4.GolesA == equipo5.GolesA);

                            if (comparar.comparacion(equipo4.GolesA, equipo5.GolesA) == 1)
                            {
                                textBox61.Text = equipo4.nombre;
                            }

                            if (comparar.comparacion(equipo4.GolesA, equipo5.GolesA) == 2)
                            {
                                textBox61.Text = equipo5.nombre;
                            }
                        }
                        equipo4.GolesR = equipo5.GolesA;
                        equipo5.GolesR = equipo4.GolesA;
                        textBox59.Text = equipo4.GolesA.ToString();
                        textBox60.Text = equipo5.GolesA.ToString();

                    }
                    if (equipo4.etapa == equipo6.etapa)
                    {
                        if (comparar.comparacion(equipo4.GolesA, equipo6.GolesA) == 1)
                        {
                            textBox61.Text = equipo4.nombre;
                        }

                        if (comparar.comparacion(equipo4.GolesA, equipo6.GolesA) == 2)
                        {
                            textBox61.Text = equipo6.nombre;
                        }
                        if (comparar.comparacion(equipo4.GolesA, equipo6.GolesA) == 3)
                        {
                            do
                            {
                                equipo4.GolesA = Partido.simulacion1(equipo4.poderf3);
                                equipo6.GolesA = Partido.simulacion2(equipo6.poderf3);
                            } while (equipo4.GolesA == equipo6.GolesA);

                            if (comparar.comparacion(equipo4.GolesA, equipo6.GolesA) == 1)
                            {
                                textBox61.Text = equipo4.nombre;
                            }

                            if (comparar.comparacion(equipo4.GolesA, equipo6.GolesA) == 2)
                            {
                                textBox61.Text = equipo6.nombre;
                            }
                        }
                        equipo4.GolesR = equipo6.GolesA;
                        equipo6.GolesR = equipo4.GolesA;
                        textBox59.Text = equipo4.GolesA.ToString();
                        textBox60.Text = equipo6.GolesA.ToString();

                    }
                    if (equipo4.etapa == equipo7.etapa)
                    {
                        if (comparar.comparacion(equipo4.GolesA, equipo7.GolesA) == 1)
                        {
                            textBox61.Text = equipo4.nombre;
                        }

                        if (comparar.comparacion(equipo4.GolesA, equipo7.GolesA) == 2)
                        {
                            textBox61.Text = equipo7.nombre;
                        }
                        if (comparar.comparacion(equipo4.GolesA, equipo7.GolesA) == 3)
                        {
                            do
                            {
                                equipo4.GolesA = Partido.simulacion1(equipo4.poderf3);
                                equipo7.GolesA = Partido.simulacion2(equipo7.poderf3);
                            } while (equipo4.GolesA == equipo7.GolesA);

                            if (comparar.comparacion(equipo4.GolesA, equipo7.GolesA) == 1)
                            {
                                textBox61.Text = equipo4.nombre;
                            }

                            if (comparar.comparacion(equipo4.GolesA, equipo7.GolesA) == 2)
                            {
                                textBox61.Text = equipo7.nombre;
                            }
                        }
                        equipo4.GolesR = equipo7.GolesA;
                        equipo7.GolesR = equipo4.GolesA;
                        textBox59.Text = equipo4.GolesA.ToString();
                        textBox60.Text = equipo7.GolesA.ToString();
                    }
                    if (equipo4.etapa == equipo8.etapa)
                    {
                        if (comparar.comparacion(equipo4.GolesA, equipo8.GolesA) == 1)
                        {
                            textBox61.Text = equipo4.nombre;
                        }

                        if (comparar.comparacion(equipo4.GolesA, equipo8.GolesA) == 2)
                        {
                            textBox61.Text = equipo8.nombre;
                        }
                        if (comparar.comparacion(equipo4.GolesA, equipo8.GolesA) == 3)
                        {
                            do
                            {
                                equipo4.GolesA = Partido.simulacion1(equipo4.poderf3);
                                equipo8.GolesA = Partido.simulacion2(equipo8.poderf3);
                            } while (equipo4.GolesA == equipo8.GolesA);

                            if (comparar.comparacion(equipo4.GolesA, equipo8.GolesA) == 1)
                            {
                                textBox61.Text = equipo4.nombre;
                            }

                            if (comparar.comparacion(equipo4.GolesA, equipo8.GolesA) == 2)
                            {
                                textBox61.Text = equipo8.nombre;
                            }
                        }
                        equipo4.GolesR = equipo8.GolesA;
                        equipo8.GolesR = equipo4.GolesA;
                        textBox59.Text = equipo4.GolesA.ToString();
                        textBox60.Text = equipo8.GolesA.ToString();
                    }
                }




                //PEGAR ABAJO DE AQUI      
            }
        }
    }
}
        
