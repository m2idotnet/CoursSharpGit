using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CoursMultiThreading
{
    public class Baignoire
    {
        private int contenu;
        public event Action pleine;
        

        public int Contenu { get => contenu; set => contenu = value; }
       

        public Baignoire()
        {
           
        }

        public void Fuite(int f)
        {
            while(Contenu >= 0)
            {
                Thread.Sleep(500);
                Contenu -=f;
                if (Contenu < 0)
                    Contenu = 0;
                Console.WriteLine("Fuite, contenu de la baignoire = " + Contenu);
            }
            
        }

        public void Pleine()
        {
            pleine();
        }
    }
}
