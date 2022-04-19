using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    abstract class Document
    {
        private string titreDoc;

        public string TitreDoc { get => titreDoc; set => titreDoc = value; }

        public Document(string titre)
        {
            this.titreDoc = titre;
        }

        public override string ToString()
        {
            return "titre : " + this.titreDoc;
        }

       
    }
}
