using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitienda
{
    class Fisico : Juegos
    {
        public enum Local
        {
            Phantom,
            MasGamer
        }

        public Local local;

        public Fisico(string nombre, Local local, float precio) : base(nombre, precio)
        {
            this.local = local;
        }
    }
}
