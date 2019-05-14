using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CarteMereFixe : CarteMere 
    {
        public CarteMereFixe(string m, string c) : base(m,c)
        {

        }

        public override string Afficher()
        {
            return $"Carte Mere fixe : {model}, Chipset : {chipset}";
        }
    }
}
