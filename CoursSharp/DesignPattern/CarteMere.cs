using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class CarteMere 
    {
        protected string model;
        protected string chipset;

        public CarteMere(string m, string c)
        {
            model = m;
            chipset = c;
        }

        public abstract string Afficher(); 
    }
}
