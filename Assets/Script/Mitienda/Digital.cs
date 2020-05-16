using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitienda
{
    class Digital : Juegos
    {
        public enum Plataforma
        {
            Playstation_Store,
            Eshop,
            Xbox_Store, 
        }

        public Plataforma plataforma;

        public Digital(string nombre,Plataforma plataforma, float precio) : base (nombre, precio)
        {
            this.plataforma = plataforma;
        }
    }
}
