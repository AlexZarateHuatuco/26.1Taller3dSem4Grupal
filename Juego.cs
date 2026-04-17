using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana4Grupal26._1
{
    internal class Juego
    {
        public Juego()
        {

        }

        public bool Combat(ClaseJugador j, Enemy e)
        {
            //Jugador ClaseJugador = new ClaseJugador(int vida, int dmg);
            while (j.vida > 0 && e.ActualLife > 0)
            {
                //ataque jugador
                Console.WriteLine("Jugador ataca");
                e.ActualLife -= j.DanoOcasionado;
                Console.WriteLine($"HP jugador: {j.vida}\nHP enemigo: {e.ActualLife}");
                Console.ReadLine();
                //ataque enemigo
                Console.WriteLine("Enemigo ataca");
                j.vida -= e.Damage;
                Console.WriteLine($"HP jugador: {j.vida}\nHP enemigo: {e.ActualLife}");
            }
            //victory check
            if(e.isDead)
            {
                return true;
                Console.WriteLine("¡VICTORIA!\nSiguiente ronda");
                Console.ReadLine();
            }
            if (j.vida <= 0)
            {
                return false;
                Console.WriteLine("¡DEROTA!\nFin del juego");
                Console.ReadLine();
            }
            
        }
        
    }
}
