using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CarteGraphiqueFixe : CarteGraphique
    {
        public CarteGraphiqueFixe(string m, string me, string c) : base(m, me, c)
        {
        }

        public override string Afficher()
        {
            return $"Carte Graphique fixe : {model}, Chipset : {chipset}, Memoire : {memoire}";
        }
    }
}
