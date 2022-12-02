using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPoo
{
    public static class Constants
    {
        // piezas
        public const char casilla = 'O';
        public const char casilla_jugador = 'X';
        public const char casilla_win = '$';
        // movimientos
        public const string movimiento = "Introduzca \n 1) arriba \n 2) abajo \n 3) derecha \n 4) izquierda";
        public const string limite_arriba = "No puedes subir más.";
        public const string limite_abajo = "No puedes bajar más.";
        public const string limite_derecha = "No puedes ir más a la derecha.";
        public const string limite_izquierda = "No puedes ir más a la izquierda.";


        // player
        public const string texto_vidas = "Vidas: ";
        public const string perder_vida = "Has perdido una vida";

    }
}
