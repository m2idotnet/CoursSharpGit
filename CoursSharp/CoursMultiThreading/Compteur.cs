using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CoursMultiThreading
{
    public class Compteur
    {
        private int n;
        private string nom;
        public static int ordre = 0;
        private static object _lock = new object();

        public int N { get => n; set => n = value; }
        public string Nom { get => nom; set => nom = value; }

        public void Compter()
        {
            Random r = new Random();
            for(int i = 1; i <= N; i++)
            {
                Thread.Sleep(r.Next(0, 3000));
                Console.WriteLine(Nom + " " + i);
            }
            lock(_lock)
            { 
                ordre++;
                Console.WriteLine(Nom + " a fini de compter jusqu'a " + N + " ordre : " + ordre);
            }
        }
    }
}
