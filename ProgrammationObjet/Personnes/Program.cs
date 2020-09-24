using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Personnes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pers = new Personne("nom","prenom",44);
            var pers2 = new Personne("nom", "prenom", 44);
            var pers3 = new Personne("nom", "prenom", 44);

            pers.Afficher();
            pers.Dispose();
            pers.Combien();
        }
    }
}
