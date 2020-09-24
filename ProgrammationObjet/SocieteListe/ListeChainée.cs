using System;
using System.Collections.Generic;

namespace SocieteListe
{
    public class Element
    {
        public object Objet { get; set; }
        public Element Suivant { get; set; }

        public Element(object objet)
        {
            Objet = objet;
            Suivant = null;
        }
    }

    public class Liste
    {
        private Element _Debut;
        private readonly List<Element> list = new List<Element>();

        public void RemplirTableau()
        {
            Element debut = _Debut;
            if (debut != null)
            {
                list.Add(debut);
                while (debut.Suivant != null)
                {
                    debut = debut.Suivant;
                    list.Add(debut);
                }
            }
        }

        public Element this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }

        public int nbliste { get; private set; }

        public Liste()
        {
            _Debut = null;
            nbliste = 0;
        }
        public void InsererDebut(object premier_objet)
        {
            Element newDebut = new Element(premier_objet)
            {
                Suivant = _Debut
            };
            _Debut = newDebut;
            nbliste++;
            RemplirTableau();
        }

        public void InsererFin(object dernier_objet)
        {
            Element newFin = new Element(dernier_objet);
            if (_Debut == null)
            {
                _Debut = newFin;
                nbliste++;
                return;
            }
            Element dernierElement = RecupereDernierElement();
            dernierElement.Suivant = newFin;
            nbliste++;
            RemplirTableau();
        }

        public Element RecupereDernierElement()
        {
            Element surf = _Debut;
            while (surf.Suivant != null)
            {
                surf = surf.Suivant;
            }
            return surf;
        }

        public void Lister()
        {
            Element debut = _Debut;
            if (debut != null)
            {
                string cumul = debut.Objet.ToString();
                while (debut.Suivant != null)
                {
                    debut = debut.Suivant;
                    cumul += "\n" + debut.Objet.ToString();
                }
                Console.WriteLine(cumul);
            }
            else
            {
                Console.WriteLine("La liste est vide");
            }
        }

        public void Vider()
        {
            _Debut = null;
            nbliste = 0;
            RemplirTableau();
        }
    }
}
