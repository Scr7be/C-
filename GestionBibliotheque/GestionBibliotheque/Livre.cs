using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Livre:Volume
    {
        private bool emprunte = false;
        private Adherent dernierAdh;
        public bool Emprunte { get => emprunte; set => emprunte = value; }
        internal Adherent DernierAdh { get => dernierAdh; set => dernierAdh = value; }

        public Livre(string titre, string auteur) : base(titre, auteur)
        {
            if (emprunte == true){
                throw new Exception("Vous ne pouvez pas emprunter ce livre,  il est actuellement indisponible");
            };
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmprunté : " + this.emprunte + "\n";
        }

    }
}
