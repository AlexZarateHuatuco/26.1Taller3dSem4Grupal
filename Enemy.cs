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
        protected int ActualLife;
        protected int Damage;
        protected bool isDead;

        public Enemy(int life, int damage)
        {
            ActualLife = life;
            Damage = damage;
            isDead = false;
        }
        public virtual int GetLife()
        {
            get { return actualLife; }
            set { actualLife = value; }
        }
        public virtual void Hurt(int amount)
        {
            ActualLife -= amount;

            if (ActualLife <= 0)
            {
                ActualLife = 0;
                isDead = true;

            }
        }
        public virtual int GetDamage()
        {
            return damage;
        }
        public virtual bool IsDead()
        {
            return _IsDead;
        }
    }
}
