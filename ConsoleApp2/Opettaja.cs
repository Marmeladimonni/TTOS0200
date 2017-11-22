using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JAMK.IT
{
    class Opettaja
    {
        public string Nimi { get; set; }

        static void Opettajalista()
        {
            List<Opettaja> Opettajat = new List<Opettaja>
            {
                new Opettaja { Nimi = "Arska" },
                new Opettaja { Nimi = "Jouni" }
            };
        }
    }
}
