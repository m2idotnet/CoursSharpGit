using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CarteMerePortable : CarteMere
    {
        public CarteMerePortable(string m, string c) : base(m, c)
        {
        }

        public override string Afficher()
        {
            return $"Carte Mere Portable : {model}, Chipset : {chipset}";
        }
    }
}
