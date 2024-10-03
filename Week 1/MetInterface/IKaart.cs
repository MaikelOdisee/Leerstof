using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conducteur
{
    internal interface IKaart
    {
        bool valideerKaart(string[] route);
        // (string[] route):Dit is de invoer (of parameter) van de functie. Het betekent dat de functie een array
        // (een geordende lijst) van strings (teksten) als input krijgt. Deze array stelt waarschijnlijk
        // de route voor die op de kaart staat.
    }
}
