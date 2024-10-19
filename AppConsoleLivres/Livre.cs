using AppConsoleLivres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        puvlic int NombrePages { get; set; }
        public Livre {string titre,string Auteur,int NombrePages}
       {Titre = titre;
        Auteur = auteur;
        NombrePages = nbrpage;
        }
      public virtual voie AfficherDettail()
            {
    Console.WriteLine($" Livre: {Titre}  auteur: {Auteur} nombre de page :{NombrePage}");
             }
    }
}
