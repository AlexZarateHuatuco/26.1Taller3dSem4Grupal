using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana4Grupal26._1
{
    internal class RangeEnemies : Enemy
    {
        public RangeEnemies(int life, int damage) : base(life, damage)
        {
            ActualLife = life;
            Damage = damage;
            isDead = false;
        }

        public override void Hurt(int amount)
        {
            ActualLife -= amount;

            if (ActualLife <= 0)
            {
                ActualLife = 0;
                isDead = true;
            }
        }
        public void RangeAttack()
        {
            Console.WriteLine("Disparo de " + Damage);
        }
    }
}
