using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3dSemana4Grupal26._1
{
    internal class RangeEnemies
    {
        int Life;
        int Damage;
        public override float GetLife()
        {
            return ActualLife;
        }
        public override float Hurt()
        {
            return ActualLife - Damage;
        }
        public override int GetDamage()
        {
            return Damage;
        }
        public override bool IsDead()
        {
            return isDead;
        }
        
    }
}
