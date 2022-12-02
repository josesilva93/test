using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace JuegoPoo
{
    class Tablero
    {
        public int posicion1 { get; set; }
        public int posicion2 { get; set; }
        public int posicionWin1 { get; set; }
        public int posicionWin2 { get; set; }

        public void CrearTablero()
        {
            this.posicion1 = GenerarRandom();
            this.posicion2 = GenerarRandom();
            this.posicionWin1 = GenerarRandom();
            this.posicionWin2 = GenerarRandom();

            int[,] matriz = new int[7, 7];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = (matriz.GetLength(0) * i) + (j + 1);
                    if (matriz[i, j] == matriz[posicion1, posicion2])
                    {
                        Console.Write(Constants.casilla_jugador);
                    }
                    else if (matriz[i, j] == matriz[posicionWin1, posicionWin2])
                    {
                        Console.Write(Constants.casilla_win);
                    }
                    else
                    {
                        Console.Write(Constants.casilla);
                    }
                }
                Console.WriteLine("");
            }
        }
         public void RefrescarTablero(int posicionPlayer, int posicionPlayer2)
        {
            int[,] matriz = new int[7, 7];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = (matriz.GetLength(0) * i) + (j + 1);
                    if (matriz[i, j] == matriz[posicionPlayer, posicionPlayer2])
                    {
                        Console.Write(Constants.casilla_jugador);                   
                    }
                    else if (matriz[i, j] == matriz[this.posicionWin1, this.posicionWin2])
                    {
                        Console.Write(Constants.casilla_win);
                    }
                    else
                    {
                        Console.Write(Constants.casilla);
                    }
                }
                Console.WriteLine("");
            }

        }
        public List<int[]> GenerarBombas(int dificultad)
        {
            List<int[]> listaBombas = new List<int[]>();
            for (int i = 0; i < dificultad; i++)
            {
                int posicionbomba1 = GenerarRandom();
                int posicionbomba2 = GenerarRandom();
                int[] posicionBomba = { posicionbomba1, posicionbomba2 };
                listaBombas.Add(posicionBomba);
            }           
            return listaBombas;
        }
        int GenerarRandom()
        {
            Random random = new Random();
            int rnd = random.Next(0, 6);
            return rnd;
        }
    }
    
}
