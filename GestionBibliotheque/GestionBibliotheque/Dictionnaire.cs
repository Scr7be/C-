using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Dictionnaire:Volume
    {

        public Dictionnaire(string titre, string auteur) : base(titre, auteur)
        {
        }
        public override string ToString()
        {
            return base.ToString() + "\n Je tiens à dire que je suis un dictionnaire" + "\n";
        }
    }
}
