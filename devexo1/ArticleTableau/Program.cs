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
            

            var cahier2 = new Article("test2", 6.99, 5, ArticleType.Droguerie);
            

            var cahier3 = new Article("test3", 9.99, 12, ArticleType.Droguerie);
            


            Article[] articlesArray = new Article[3];
            articlesArray[0] = cahier;
            articlesArray[1] = cahier2;
            articlesArray[2] = cahier3;
            for (int i = 0; i < articlesArray.Length; i++) { articlesArray[i].Afficher(); }

            Console.WriteLine("Nom :");
            string Nom = Console.ReadLine();

            Console.WriteLine("Prix :");
            double Prix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantite :");
            int Quantite = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("type :");
            ArticleType type = (ArticleType)Enum.Parse(typeof(ArticleType), Console.ReadLine().ToString(), true);

            var cahier4 = new Article(Nom, Prix, Quantite, type);

            cahier4.Afficher();
            cahier4.ajouter();
            cahier4.Afficher();
            cahier4.Retirer();
            cahier4.Afficher();
            cahier4.Retirer();
            cahier4.Afficher();
        }

    }
}
