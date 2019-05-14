using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class OrdinateurPortable : IOrdinateur
    {
        public CarteGraphique CreerCarteGraphique(string m, string me, string c)
        {
            return new CarteGraphiquePortable(m, me, c);
        }

        public CarteMere CreerCarteMere(string m, string c)
        {
            return new CarteMerePortable(m, c);
        }
    }
}
