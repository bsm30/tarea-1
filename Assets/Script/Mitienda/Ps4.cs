using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitienda
{
    class Ps4 : Consolas
    {
        public enum Type
        {
            Playstation_1,
            Playstation_2,
            Playstation_4,
        }

        public Type type;
            
        public Ps4(string nombre,Type type, float precio) : base(nombre, precio)
        {

        }

        public void ConnectPsMove()
        {

        }
    }
}
