﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class OrdinateurFixe : IOrdinateur
    {
        public CarteGraphique CreerCarteGraphique(string m, string me, string c)
        {
            return new CarteGraphiqueFixe(m, me, c);
        }

        public CarteMere CreerCarteMere(string m, string c)
        {
            return new CarteMereFixe(m, c);
        }
    }
}
