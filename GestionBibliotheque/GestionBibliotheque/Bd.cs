using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Bd:Volume
    {
        private string nomDessinateur;

        public string NomDessinateur { get => nomDessinateur; set => nomDessinateur = value; }

        public Bd(string titre, string auteur, string dessinateur):base(titre, auteur)
        {
            this.NomDessinateur = dessinateur;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Dessinateur : " + this.nomDessinateur + "\n";
        }


    }
}
