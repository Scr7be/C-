using System;
using System.Collections.Generic;

namespace GestionBibliotheque
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bibliotheque bibli = new Bibliotheque();

                Adherent ad = new Adherent("Dupont", "Jean");
                bibli.AjouterAdherent(ad);
                Adherent ad2 = new Adherent("Suhard", "Noah");
                bibli.AjouterAdherent(ad2);
                Adherent ad3 = new Adherent("Johnny", "Lolo");
                bibli.AjouterAdherent(ad3);

                Livre livre1 = new Livre("Misérable", "Hugo V");
                Livre livre2 = new Livre("Le capital", "Marx C");
                Livre livre4 = new Livre("Bonjour", "Moi");

                bibli.AjouterDocument(livre1);
                bibli.AjouterDocument(livre2);
                bibli.AjouterDocument(livre4);
                bibli.AjouterDocument(new Journal("Dr Dobbs", Convert.ToDateTime("12/05/2017")));
                bibli.AjouterDocument(new Bd("Thorgal : La galère noire", "Van Hamme", "Rovinsky"));
                bibli.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !"));

                /* Console.WriteLine("-------Liste des documents-------");
                 foreach (Document d in bibli.Docs)
                 {
                     Console.WriteLine(d);
                 }
                 Console.ReadKey();*/

                ad2.EmprunteLivre(livre1);
                ad2.EmprunteLivre(livre2);

                /*Console.WriteLine("-------Liste des livres-------");
                foreach (Livre l in ad2.LesLivres)
                {
                    Console.WriteLine(l);
                }
                Console.ReadKey();

                ad2.RendreLivre(livre1);

                Console.WriteLine("-------Liste des livres-------");
                foreach (Livre l in ad2.LesLivres)
                {
                    Console.WriteLine(l);
                }
                Console.ReadKey();*/


                //Exercice 3

                /*List<Adherent> adhTrouver = bibli.chercherAdherent("daniel", "Suhard");
                foreach (Adherent a in adhTrouver)
                {
                    Console.WriteLine(a);
                }*/

                //Exercice 3
                /*List<Document> docTrouver = bibli.chercherDocument("ob");
                foreach(Document d in docTrouver)
                {
                    Console.WriteLine(d);
                }*/

                bibli.listDocument();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur a été détectée : " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
