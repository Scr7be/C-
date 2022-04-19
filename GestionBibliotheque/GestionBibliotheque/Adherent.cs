using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Adherent
    {
        private string nomAdh;
        private string prenomAdh;
        private List<Livre> listLivres;

        public string NomAdh { get => nomAdh; set => nomAdh = value; }
        public string PrenomAdh { get => prenomAdh; set => prenomAdh = value; }
        internal List<Livre> ListLivres { get => listLivres; set => listLivres = value; }
        

        public Adherent( string nom, string prenom)
        {
            this.nomAdh = nom;
            this.prenomAdh = prenom;
            this.listLivres = new List<Livre>();
        }

        public bool EmprunteLivre(Livre l)
        {
            if (l.Emprunte == false)
            {
                l.Emprunte = true;
                l.DernierAdh = this;
                ListLivres.Add(l);
            }
            return l.Emprunte;
        }

        public void RendreLivre(Livre l)
        {
            
            ListLivres.Remove(l);
            l.Emprunte = false;
            Console.WriteLine(l);
        }

        public override string ToString()
        {
            return "Je suis un adhérent, je m'appelle " + this.nomAdh +" "+ this.prenomAdh;
        }

        public bool trouverLivre(Livre l)
        {
            bool verite;
            foreach(Livre li in listLivres)
            {
                if(li == l)
                {
                    return verite = true;
                }
            }
            return verite = false;
        }
    }
}
