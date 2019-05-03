using System;
using System.Collections.Generic;
using System.Text;

namespace CoursSharp
{
    public class Calcule
    {
        public delegate int delegueCalcule(int a, int b);

        public Action<int> delegueAffichage;
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

        public int Calculer(Func<int[], int> methodeCalcule, params int[] parms )
        {
            return methodeCalcule(parms);
        }

       

        public void AfficherResult(int resultat, Action<int> MethodeAffichage)
        {
            MethodeAffichage(resultat);
        }

        public void declancherTousMethode(int a)
        {
            delegueAffichage(a);
        }



    }
}
