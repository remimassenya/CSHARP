using System;
namespace devexo1
{
    public class Disque : Article
    {
        protected string label;

        public void Ecouter() { }

        public Disque(string Nom, int Quantite, double Prix) : base(Nom, Prix, Quantite)
        { }

    }
}
