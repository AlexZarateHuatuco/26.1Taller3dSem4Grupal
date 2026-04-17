using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseJugador
{
    internal class ClaseJugador
    {
        public int vida;
        public int DañoOcacionado = 5;

        public ClaseJugador(int VIDA, int DAÑOOCACIONADO)
        {
            vida = VIDA;
            DañoOcacionado = DAÑOOCACIONADO;
        }

        public int recibirDaño()
        {
            return vida-3;
        }
        public int dañoOcacionado()
        {
            return DañoOcacionado;
        }
    }
}