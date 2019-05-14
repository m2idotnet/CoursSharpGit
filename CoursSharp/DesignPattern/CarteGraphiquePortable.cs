using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CarteGraphiquePortable : CarteGraphique
    {
        public CarteGraphiquePortable(string m, string me, string c) : base(m, me, c)
        {
        }

        public override string Afficher()
        {
            return $"Carte Graphique Portable : {model}, Chipset : {chipset}, Memoire : {memoire}";
        }
    }
}
