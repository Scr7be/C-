using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Bibliotheque
    {
        private List<Document> docs;
        private List<Adherent> adh;

        internal List<Document> Docs { get => docs; set => docs = value; }
        internal List<Adherent> Adh { get => adh; set => adh = value; }

        public Bibliotheque()
        {
            this.adh = new List<Adherent>();
            this.docs = new List<Document>();
        }

        public void AjouterAdherent(Adherent a)
        {
            Adh.Add(a);
        }

        public void AjouterDocument(Document d)
        {
            Docs.Add(d);
        }

        public List<Document> chercherDocument(string texteRech)
        {
            List<Document> list = new List<Document>();
            foreach(Document d in Docs)
            {
                if (d.TitreDoc.IndexOf(texteRech) != -1)
                {
                    list.Add(d);
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Aucun document n'ont été trouver");
            }
            return list;
        }

        public List<Adherent> chercherAdherent(string adhRechPrenom, string adhRechNom)
        {
            List<Adherent> listAdh = new List<Adherent>();
            foreach (Adherent a in Adh)
            {
                if (a.NomAdh.IndexOf(adhRechNom) != -1 && a.PrenomAdh.IndexOf(adhRechPrenom) != -1)
                {
                    listAdh.Add(a);
                }
            }
            if (listAdh.Count == 0)
            {
               Console.WriteLine("Aucun adhérent n'a été trouver");
            }
            
            return listAdh;
        }

        public void listDocument()
        {
            foreach (Document d in this.Docs) 
            {
                if (d is Livre)
                {
                    Livre book = (Livre)d;
                    foreach (Adherent adhe in this.adh)
                    {
                        if (book.Emprunte && adhe.trouverLivre(book) == true)
                        {
                            Console.WriteLine("Emprunteur : " + adhe.NomAdh + " " + adhe.PrenomAdh);
                        }
                    }
                    Console.WriteLine("Livre : " + d.ToString());
                }
                else if (d is Journal)
                {
                    Console.WriteLine("Journal : " + d.ToString());
                }
                else if (d is Bd)
                {
                    Console.WriteLine("BD : " + d.ToString());
                }
                else if (d is Dictionnaire)
                {
                    Console.WriteLine("Dictionnaire : " + d.ToString());
                }
            }
        }
    }
}
