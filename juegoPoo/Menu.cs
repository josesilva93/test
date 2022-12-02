using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPoo
{
    class Menu
    {
        public int dificultad { get; set; }
        public bool dificultadElegida { get; set; }
        public Menu() 
        {
            this.dificultad = -1;
            
            while(!this.dificultadElegida)
            {            
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("Selecciona un nivel de dificultar");
                Console.WriteLine("Introduzca \n 1) facil \n 2) medio \n" +
                "3) dificil \n");
                Console.WriteLine("_____________________________________________");
                dificultad = Convert.ToInt32(Console.ReadLine());
                switch (dificultad)
                {
                    case 1:
                        this.dificultad = 1;
                        this.dificultadElegida = true;
                        break;
                    case 2:
                        this.dificultad = 2;
                        this.dificultadElegida = true;
                        break;
                    case 3:
                        this.dificultad = 3;
                        this.dificultadElegida = true;
                        break;
                }
                Console.WriteLine(this.dificultad);
            }

        }
    }
}
