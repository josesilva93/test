using juegoPoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPoo
{
    class Player
    {
        public int vidas { get; set; }
        public int posicion1 { get; set; }
        public int posicion2 { get; set; }

        public Player(int posicion1, int posicion2) 
        {
            this.posicion1 = posicion1;
            this.posicion2 = posicion2;
        }
        public void CambiarPosicion(int position1, int position2)
        {
            Console.WriteLine("_____________________________________________");
            Console.WriteLine(Constants.movimiento);
            int direccion = Convert.ToInt32(Console.ReadLine());

            if (direccion == 1)
            {
                if (position1 <= 0)
                {
                    Console.WriteLine(Constants.limite_arriba);
                }
                else
                {
                    this.posicion1 = position1 - 1;

                }
            }
            else if (direccion == 2)
            {
                if (position1 >= 6)
                {
                    Console.WriteLine(Constants.limite_abajo);
                }
                else
                {
                    this.posicion1 = position1 + 1;

                }
            }
            else if (direccion == 3)
            {
                if (position2 == 6)
                {
                    Console.WriteLine(Constants.limite_derecha);
                }
                else
                {
                    this.posicion2 = position2 + 1;

                }
            }
            else if (direccion == 4)
            {
                if (position2 == 0)
                {
                    Console.WriteLine(Constants.limite_izquierda);
                }
                else
                {
                    this.posicion2 = position2 - 1;

                }
            }
        }
    }
}
