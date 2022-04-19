using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBibliotheque
{
    class Journal:Document
    {
        private DateTime dateParution;

        public DateTime DateParution { get => dateParution; set => dateParution = value; }

        public Journal(string titre, DateTime date) :base(titre)
        {
            this.DateParution = date;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Date : " + this.dateParution + "\n";
        }

    }
}
