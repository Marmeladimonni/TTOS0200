using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JAMK.IT
{
    class Opiskelija
    {
        public string Nimi { get; set; }

        static void Opiskelijalista()
        {
            List<Opiskelija> Opiskelijat = new List<Opiskelija>
            {
            new Opiskelija { Nimi = "Hessu" },
            new Opiskelija { Nimi = "Anni" },
            new Opiskelija { Nimi = "Ossi" }
            };
        }
    }
}
