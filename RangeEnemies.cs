using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana4Grupal26._1
{
    internal class RangeEnemies : Enemy
    {
        ClaseJugador cj = new ClaseJugador();
        public override int GetLife()
        {
            return ActualLife;
        }
        public override int Hurt()
        {
            return ActualLife - cj.DañoOcacionado;
        }
        public override int GetDamage()
        {
            return Damage;
        }
        public override bool IsDead()
        {
            if(ActualLife == 0)
            {
                _IsDead = true;
            }
            return _IsDead;
        }
        public void RangeAttack()
        {
            Console.WriteLine("Disparo de " + Damage);
        }
    }
}
