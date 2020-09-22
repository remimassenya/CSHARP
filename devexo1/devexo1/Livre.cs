using System;
namespace devexo1
{
    public class Livre : Article
    {
        protected string isbn;
        protected int nbPages;

        public Livre(string Nom, int Quantite, double Prix) : base(Nom, Prix, Quantite)
        { }

    }
}
