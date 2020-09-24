using System;

namespace SocieteEnumeration
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


            ListeEnumeration personnesEnumeration = new ListeEnumeration (personnes);
            do
            {
                Console.WriteLine(personnesEnumeration.Current().ToString());
            }
            while (personnesEnumeration.MoveNext());
        }

    }
}
