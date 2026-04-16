using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Taller3dSemana4Grupal26._1
{
    internal class EnemyMelee : Enemy
    {
        public EnemyMelee(float life, int damage) : base(life, damage)
        {
        }

        
        public void MeleeAttack()
        {
            Console.WriteLine("Ataque cuerpo a cuerpo de " + Damage);
        }
    }
}
