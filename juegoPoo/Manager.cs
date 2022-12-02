using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JuegoPoo
{
    class Manager
    {
        D
        public bool isPlaying { get; set; }
        public Manager()
        {
            isPlaying = true;
            Menu menu = new Menu();
            Tablero tablero = new Tablero();
            tablero.CrearTablero();
            List<int[]> bombas;
            Player player = new Player(tablero.posicion1, tablero.posicion2);
            Console.WriteLine(menu.dificultad);
            if (menu.dificultad == 1)
            {
                player.vidas = 3;
                bombas = tablero.GenerarBombas(3);
            }
            else if (menu.dificultad == 2)
            {
                player.vidas = 2;
                bombas = tablero.GenerarBombas(5);
            }
            else
            {
                player.vidas = 1;
                bombas = tablero.GenerarBombas(14);
            }
            
            while (this.isPlaying == true)
            {
                Console.WriteLine(Constants.texto_vidas + player.vidas);
                player.CambiarPosicion(player.posicion1, player.posicion2);
                if (ComprobarColisionBomba(player.posicion1, player.posicion2, bombas))
                {
                    player.vidas = player.vidas - 1;
                    if (player.vidas == 0)
                    {
                        this.isPlaying = false;
                        Console.WriteLine("Tu numero de vidas es " + player.vidas + " has perdido.");
                    }
                }
                tablero.RefrescarTablero(player.posicion1, player.posicion2);

                
                Console.WriteLine("Player pos1: " + player.posicion1 + "Player pos2: " + player.posicion2);

                ComprobarWin(player.posicion1, player.posicion2, tablero.posicionWin1, tablero.posicionWin2);
            }
        }
        public bool ComprobarColisionBomba(int posicionPlayer1, int posicionPlayer2, List<int[]> bombas)
        {
            foreach (int[] bomba in bombas)
            {
                if (posicionPlayer1 == bomba[0] && posicionPlayer2 == bomba[1])
                {
                    return true;
                }
                Console.WriteLine("Bomba pos1: " + bomba[0] + "Bomba pos2: " + bomba[1]);
            }
            return false;
        }
        public void ComprobarWin(int posicionPlayer1, int posicionPlayer2, int posicionWin1, int posicionWin2)
        {
            if (posicionPlayer1 == posicionWin1 && posicionPlayer2 == posicionWin2)
            {
                this.isPlaying = false;
                Console.WriteLine("You win.");
            }
        }
      
    }
}
