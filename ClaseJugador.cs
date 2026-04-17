using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseJugador
{
    internal class ClassPlayer
    {
        public int health;
        public int damageDealt = 5;

        public ClassPlayer(int Health, int DamageDealt)
        {
            health = Health;
            damageDealt = DamageDealt;
        }

        public int DamageReceived()
        {
            return health - 3;
        }
        public int dañoOcacionado()
        {
            return damageDealt;
        }
    }
}