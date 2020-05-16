using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitienda
{
    class Xbox : Consolas
    {
        public enum Type
        {
            Xbox_one,
            Xbox_360,
        }

        public Type type;

        public Xbox(string nombre,Type type, float precio) : base(nombre, precio)
        {

        }
    }
}
