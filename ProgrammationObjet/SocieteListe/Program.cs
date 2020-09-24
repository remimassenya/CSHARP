using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SocieteListe
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Employe emp1 = new Employe("jean", "michel", 44, 1900.50);
            Employe emp2 = new Employe("jean", "patrick", 24, 1500);
            Employe emp3 = new Employe("jean", "moulin", 34, 1500);
            Employe emp4 = new Employe("jean", "claude", 54, 1500);
            Employe emp5 = new Employe("jean", "marie", 14, 1500);
            Chef chef1 = new Chef("marie", "christine", 44, 2300, "RH");
            Chef chef2 = new Chef("marie", "therese", 44, 2300, "DSI");
            Directeur dir1 = new Directeur("anne", "lise", 44, 2300, "ELITE", "Leclerc");

            

            Liste personnes = new Liste();
            personnes.InsererDebut(emp1);
            personnes.InsererDebut(emp2);
            personnes.InsererDebut(emp3);
            personnes.InsererDebut(emp4);
            personnes.InsererDebut(emp5);
            personnes.InsererDebut(chef1);
            personnes.InsererDebut(chef2);
            personnes.InsererDebut(dir1);

            personnes.Lister();
            personnes.Vider();
            personnes.Lister();

            personnes.InsererFin(emp1);
            personnes.InsererFin(emp2);
            personnes.InsererFin(emp3);
            personnes.InsererFin(emp4);
            personnes.InsererFin(emp5);
            personnes.InsererFin(chef1);
            personnes.InsererFin(chef2);
            personnes.InsererFin(dir1);

            personnes.Lister();
            /*
            for (int i = 0; i < personnes.nbliste; i++)
            {
                Console.WriteLine(personnes[i].Objet.ToString());
            }
            */

        }

    }
}
