using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana4Grupal26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego game = new Juego();
            List<Enemy> enemigos = new List<Enemy>();
            //crear jugador
            Console.WriteLine("Ingresa la cantidad de vida del jugador:");
            int hp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el daño que ocasiona el jugador:");
            int dmg = int.Parse(Console.ReadLine());
            //verificar stats
            if (hp > 100 || dmg > 100)
            {
                Console.WriteLine("No se puede crear al jugador (stats mayores a 100).");
            }
            else
            {
                ClaseJugador jugador = new ClaseJugador(hp, dmg);
            }
            //ejecutar combate (1 enemigo)
            bool isAlive = true;
            for (int i = 0; i < enemigos.Count; i++ && isAlive)
            {
                //derrota = game over
                if (Juego.Combat(jugador, enemigos[i]) == false)
                {
                    isAlive = false;
                }
                //victoria = sgte enemigo
            }
            //ya no hay enemigos = victoria
            Console.WriteLine("Has completado el juego. ¡Felicidades!");
        }
    }
}
