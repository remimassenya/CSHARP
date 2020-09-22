using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace devexo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cahier = new Article("test", 6.99, 5, ArticleType.Alimentaire);
            cahier.Afficher();

            var cahier2 = new Article("test2", 6.99, 5, ArticleType.Droguerie);
            cahier2.Afficher();
            cahier2.ajouter();
            cahier2.Afficher();


            Console.WriteLine("Nom :");
            string Nom = Console.ReadLine();

            Console.WriteLine("Prix :");
            double Prix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantite :");
            int Quantite = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("type :");
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), Console.ReadLine().ToString(), true);

            var cahier3 = new Article(Nom, Prix, Quantite, type);

            cahier3.Afficher();
            cahier3.ajouter();
            cahier3.Afficher();
            cahier3.Retirer();
            cahier3.Afficher();
            cahier3.Retirer();
            cahier3.Afficher();
        }
                
    }
}
