using System;
namespace Personnes
{
    public class Personne
    {
        private string Nom;
        private string Prenom;
        private int Age;

        public void Afficher()
        {
            Console.WriteLine("Nom=" + this.Nom + " Prenom=" + this.Prenom + " Age=" + this.Age);
        }

        public void Combien()
        {
            Console.WriteLine("Nom=" + this.Nom + " Prenom=" + this.Prenom + " Age=" + this.Age);
        }

        //Constructeur par paramètre
        public Personne(string Nom, string Prenom, int Age)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Age = Age;
        }
    }
}
