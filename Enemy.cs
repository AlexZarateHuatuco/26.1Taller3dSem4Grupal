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
        int actualLife;
        int damage;
        bool isDead; 
        public int ActualLife
        {
            get { return actualLife; }
            set { actualLife = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public bool _IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }
        public virtual int GetLife()
        {
            return actualLife;
        }
        public virtual int Hurt()
        {
            return actualLife-damage;
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
