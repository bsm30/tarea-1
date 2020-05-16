using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitienda
{
    class Nintendo : Consolas
    {
        public enum Type
        {
            Nintendo_Switch,
            Nintendo_64,
            Nintendo_3DS
        }

        public Type type;

        public Nintendo(string nombre,Type type, float precio) : base(nombre, precio)
        {

        }

        public void LeerCartuchos()
        {

        }
    }
}

