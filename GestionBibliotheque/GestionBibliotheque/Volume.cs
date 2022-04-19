using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    abstract class Volume:Document
    {
        private string auteurVol;

        protected string AuteurVol { get => auteurVol; set => auteurVol = value; }

        public Volume(string titre, string nomAut) : base(titre)
        {
            this.auteurVol = nomAut;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Auteur :  " + this.auteurVol;
        }


    }
}
