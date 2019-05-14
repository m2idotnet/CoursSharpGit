using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class CarteGraphique
    {
        protected string model;
        protected string memoire;
        protected string chipset;

        public CarteGraphique(string m, string me, string c)
        {
            model = m;
            memoire = me;
            chipset = c;
        }

        public abstract string Afficher();
    }
}
