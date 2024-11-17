using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue
    {
        public string Titre { get; set; }
        public string Domaine { get; set; }
        public DateTime DatePublication{get; set;}
    }
    public Revue(string titre, string domaine, DateTime datePublication)
    {
        Titre = titre;
        Domaine = domaine;
        DatePublication = datePublication;
    }
    public void AfficherDetails()
    {
        Console.WriteLine($"Titre: {Titre}, Domaine: {Domaine}, Date de publication: {DatePublication}");
    }
}
