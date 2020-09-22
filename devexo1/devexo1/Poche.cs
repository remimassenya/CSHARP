using System;
namespace devexo1
{
    public class Poche : Livre
    {
        public string categorie;


        public Poche(string Nom, int Quantite, double Prix) : base(Nom, Quantite, Prix)
        { }
    }
}
