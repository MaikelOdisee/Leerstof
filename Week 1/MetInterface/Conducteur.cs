using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conducteur
{
    internal class Conducteur
    {

        private string[] route;

        // als argument voor de conducteur geef je een array mee
        public Conducteur(string[] route)
        {
            this.route = route;
        }

        public bool ValideerTicket(IKaart ticket) 
        {
            return ticket.valideerKaart(route);
        }
    }
}
