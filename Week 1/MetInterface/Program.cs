using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conducteur
{
    internal class Program
    {
        static void Main(string[] args)
        {   // je maakt een nieuw object aan van de klasse Conucteur en geeft als argument een array mee
            Conducteur conducteur = new Conducteur(new string[]{ "Oostende", "Brugge", "Gent", "Denderleeuw", "Brussel" });

            Console.WriteLine(conducteur.ValideerTicket(new EnkelTicket("Brugge", "Denderleeuw", DateTime.Today)));
            Console.WriteLine(conducteur.ValideerTicket(new Abonnement(DateTime.Today, DateTime.Today, "Brugge", "Antwerpen")));
            Console.WriteLine(conducteur.ValideerTicket(new Multipass("Denderleeuw", "Brugge")));

            Console.WriteLine("Done");
        }
    }
}
