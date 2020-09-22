using System;
namespace devexo1
{
    public enum ArticleType { Alimentaire, Droguerie, Habillement, Loisir }

    public class Article
    {


        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        protected ArticleType type;


        public void ajouter() {

            this.Quantite = this.Quantite + 1;

        }

        public void Afficher() {
            Console.WriteLine("prix=" + this.Prix + " Nom=" + this.Nom + " Quantite=" + this.Quantite + " Type=" + this.type);
        }

        public void Retirer() {
            this.Quantite = this.Quantite - 1;
        }

        //Constructeur par paramètre
        public Article(string Nom, double Prix, int Quantite)
        {
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantite = Quantite;

        }


        //Constructeur par paramètre
        public Article(string Nom, double Prix, int Quantite, ArticleType type)
        {
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantite = Quantite;
            this.type = type;
            
        }

        ~Article(){
            Console.WriteLine("L'instance à été détruite.");
        }
    }
}
