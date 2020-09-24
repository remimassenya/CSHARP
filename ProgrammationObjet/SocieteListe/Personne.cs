using System;
namespace SocieteListe
{ 
    public class Personne : IDisposable
    {
        protected static int nb = 0;
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected int Age { get; set; }


        public Personne(string nom, string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            nb++;
        }

        public void Combien()
        {
            Console.WriteLine($"Nb personne créer : {nb}");
        }

        public void Dispose()
        {
            nb--;
        }




        public override string ToString()
        {
            return $"Nom de la personne : {Nom}, prénom de la personne : {Prenom}, age de la personne : {Age}";
        }

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public static Personne operator ++(Personne personne)
        {
            personne.Age++;
            return personne;
        }




    }
}