using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DatePublication { get; set; }
        public Roman(string titre, string auteur, DateTime datePublication)

        {
            Titre = titre;
            Auteur = auteur;
            DatePublication = datePublication;
        }
        public void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Date de publication: {DatePublication.ToShortDateString()}");
        }
    }
}
