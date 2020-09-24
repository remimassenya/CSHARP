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

            var emp1 = new Employe("jean", "michel", 44, 1900.50);
            var emp2 = new Employe("jean", "patrick", 24, 1500);
            var emp3 = new Employe("jean", "moulin", 34, 1500);
            var emp4 = new Employe("jean", "claude", 54, 1500);
            var emp5 = new Employe("jean", "marie", 14, 1500);
            var chef1 = new Chef("marie", "christine", 44, 2300, "RH");
            var chef2 = new Chef("marie", "therese", 44, 2300, "DSI");
            var dir1 = new Directeur("anne", "lise", 44, 2300, "ELITE", "Leclerc");

            dir1.Afficher();
            chef2.Afficher();
            emp3.Afficher();

            Personne[] personnesArray = new Personne[8];
            personnesArray[0] = emp1;
            personnesArray[1] = emp2;
            personnesArray[2] = emp3;
            personnesArray[3] = emp4;
            personnesArray[4] = emp5;
            personnesArray[5] = chef1;
            personnesArray[6] = chef2;
            personnesArray[7] = dir1;

            for (int i = 0; i < personnesArray.Length; i++) { personnesArray[i].Afficher(); }

            emp1++;
            emp2.Salaire = 1600;
            chef1.Service = "DRH";


            for (int i = 0; i < personnesArray.Length; i++) { personnesArray[i].Afficher(); }
        }

    }
}
