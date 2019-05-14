using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface IOrdinateur
    {
        CarteMere CreerCarteMere(string m, string c);
        CarteGraphique CreerCarteGraphique(string m, string me, string c);
    }
}
