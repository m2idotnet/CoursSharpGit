using System;
using System.Threading;

namespace CoursMultiThreading
{
    class Program
    {
        private static object _lock = new object();
        private static Mutex m1 = new Mutex();
        private static Mutex m2 = new Mutex();
        private static Mutex m3 = new Mutex();
        private static int v1;
        private static int v2; 
        static void Main(string[] args)
        {
            //Pour créer un thread on utilise la classe Thread
            //Thread t1 = new Thread(MethodeThread1);
            //Thread t2 = new Thread(MethodeThread2);
            ////Démarrer un Thread
            //t1.Start();
            //t2.Start();
            ////t1.Abort();
            //Console.WriteLine("Message du thread principal");
            //Créer des threads avec des parametres
            //Thread t1 = new Thread(Afficher);
            //Thread t2 = new Thread(Afficher);
            //Personne p1 = new Personne { Nom = "tata", Prenom = "toto" };
            //Personne p2 = new Personne { Nom = "titi", Prenom = "Minet" };
            //t1.Start(p1);
            //t2.Start(p1);
            Console.ReadLine();
        }
        //static void MethodeThread1()
        //{
        //    for(int i=1; i<100; i++)
        //        Console.WriteLine("Je suis la methode 1 executée dans un thread secondaire "+i);
        //}
        //static void MethodeThread2()
        //{
        //    for (int i = 1; i < 100; i++)
        //        Console.WriteLine("Je suis la methode 2 executée dans un thread secondaire "+i);
        //}

        //static void Afficher(object c)
        //{
        //    //utilisation du lock pour synchronisation d'acces au data
        //    lock(_lock)
        //    {
        //        Personne p = c as Personne;
        //        for (int i = 1; i < 100; i++)
        //        {
        //            Console.WriteLine(p.Prenom + " " + p.Nom);
        //            if (i == 20)
        //            {
        //                p.Nom = "Nom 20";
        //            }
        //        }
        //    }    
        //}

        //static void Afficher(object c)
        //{
        //    m1.WaitOne();
        //    Personne p = c as Personne;
        //    for (int i = 1; i < 100; i++)
        //    {
        //        Console.WriteLine(p.Prenom + " " + p.Nom);
        //        if (i == 20)
        //        {
        //            p.Nom = "Nom 20";
        //        }
        //    }
        //    m1.ReleaseMutex();
        //}

        static void init()
        {
            m1.WaitOne();
            m2.WaitOne();
            v1 = 10;
            m1.ReleaseMutex();
            v2 = 20;
            m2.ReleaseMutex();
        }

        static void ModifV1()
        {
            m1.WaitOne();
            v1 = v1 + 10;
            m1.ReleaseMutex();
        }
        static void ModifV2()
        {
            m2.WaitOne();
            v2 = v2 + 10;
            m2.ReleaseMutex();
        }
    }
}
