using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Taller3dSemana4Grupal26._1
{
    internal class Enemy
    {
        public virtual float GetLife()
        {
            return ActualLife;
        }
        public virtual float Hurt()
        {
            return ActualLife-Damage;
        }
        public virtual int GetDamage()
        {
            return Damage;
        }
        public virtual bool IsDead()
        {
            return isDead;
        }
    }
}
