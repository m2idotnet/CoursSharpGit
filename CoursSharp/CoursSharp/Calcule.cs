using System;
using System.Collections.Generic;
using System.Text;

namespace CoursSharp
{
    public class Calcule
    {
        public delegate int delegueCalcule(int a, int b);
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int soustraction(int a, int b)
        {
            return a - b;
        }

        //public int Calculer(int a, int b, delegueCalcule methodeCalcule)
        //{
        //    return methodeCalcule(a, b);
        //}

        public int Calculer(int a, int b, Func<int,int,int> methodeCalcule)
        {
            return methodeCalcule(a, b);
        }

        public void AfficherResult(int resultat, Action<int> MethodeAffichage)
        {
            MethodeAffichage(resultat);
        }

    }
}
