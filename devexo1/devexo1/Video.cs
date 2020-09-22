using System;
namespace devexo1
{
    public class Video : Article
    {
        protected double duree;

        public Video(string Nom, int Quantite, double Prix) : base(Nom, Prix, Quantite)
        {}

    }
}
