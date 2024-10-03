using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conducteur
{
    internal class Multipass
    {
        public string VanLocatie { get; private set; }
        public string NaarLocatie { get; private set; }
        
        //je hebt hier een list gemaakt van het type "Class = Rit"
        public List<Rit> Ritten { get; private set; }
        
        public Multipass(string vanLocatie, string naarLocatie)
        {
            VanLocatie = vanLocatie;
            NaarLocatie = naarLocatie;
        }

        public bool RitToevoegen(string naarLocatie)
        {
            if (Ritten.Count < 10)
            {// ritten toevoegen aan je List - omdat je met een klasse werkt moet je daar "new Rit" aan toevoegen
                Ritten.Add(new Rit(naarLocatie));
                return true;
            }
            return false;
        }
    }
}
