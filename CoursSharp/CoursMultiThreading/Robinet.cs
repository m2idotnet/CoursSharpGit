using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CoursMultiThreading
{
    public class Robinet
    {
        public void debite(int c, Baignoire b)
        {
            while(b.Contenu <= Eau.Volume)
            {
                Thread.Sleep(100);
                b.Contenu += c;
                Console.WriteLine("Remplissage, contenu de la baignoire = " + b.Contenu);
            }
            if(b.Contenu >= Eau.Volume )
            {
                b.Pleine();
            }
        }
    }
}
