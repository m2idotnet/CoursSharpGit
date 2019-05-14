using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoursMultiThreading
{
    class Program
    {
        //private static object _lock = new object();
        //private static Mutex m1 = new Mutex();
        //private static Mutex m2 = new Mutex();
        //private static Mutex m3 = new Mutex();
        //private static int v1;
        //private static int v2;
        //private static SemaphoreSlim s = new SemaphoreSlim(3);
        static void Main(string[] args)
        {

            /*Pour créer un thread on utilise la classe Thread
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
            //t2.Start(p1);*/
            //for(int i=1; i <= 10; i++)
            //{
            //    Thread t = new Thread(Afficher);
            //    t.Start(i);
            //}
            //Correction ex1
            //Compteur c1 = new Compteur { Nom = "toto", N = 10 };
            //Compteur c2 = new Compteur { Nom = "tata", N = 15 };
            //Thread t = new Thread(c1.Compter);

            //Thread t2 = new Thread(c2.Compter);
            //t.Start();
            //t2.Start();

            //Utilisation de pool de thread
            //ThreadPool.QueueUserWorkItem((o) => Console.Write(o), "Coucou");
            //ThreadPool.QueueUserWorkItem(afficher, "Coucou");
            //ThreadPool.QueueUserWorkItem(afficher, "bonjour");
            //ThreadPool.QueueUserWorkItem(afficher, 10);

            //Utilisation des tasks
            //Task<string> t = Task.Run(new Func<string>(() => {
            //    return "coucou";
            //    }));
            //Task<string> t = Task.Run(new Func<string>(() => {
            //    throw new Exception("Exception levee par la task");
            //}));
            //Task.Run(() => { });

            //try
            //{
            //    Console.WriteLine(t.Result);
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Baignoire b = new Baignoire();
            b.pleine += methodePleine;
            Robinet r = new Robinet();
            Task.Factory.StartNew(() => r.debite(50, b));
            Task.Factory.StartNew(() => b.Fuite(10));
            //Task t = Task.Run(() => r.debite(50, b));
            //Task t2 = Task.Run(() => b.Fuite(10));
            //Thread t1 = new Thread(() => r.debite(50, b));
            //Thread t2 = new Thread(() => b.Fuite(10));
            //t1.Start();
            //t2.Start();
            Console.ReadLine();
        }

        static void methodePleine()
        {
            Console.WriteLine("Baignoire enfin pleine !");
        }
        static void afficher(object c)
        {
            try
            {
                if (c.GetType() != typeof(string))
                    throw new Exception("Execption error");
                else
                    for (int i = 1; i < 100; i++)
                        Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
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

        //static void init()
        //{
        //    m1.WaitOne();
        //    m2.WaitOne();
        //    v1 = 10;
        //    m1.ReleaseMutex();
        //    v2 = 20;
        //    m2.ReleaseMutex();
        //}

        //static void ModifV1()
        //{
        //    m1.WaitOne();
        //    v1 = v1 + 10;
        //    m1.ReleaseMutex();
        //}
        //static void ModifV2()
        //{
        //    m2.WaitOne();
        //    v2 = v2 + 10;
        //    m2.ReleaseMutex();
        //}

        //static void Afficher(object c)
        //{
        //    Console.WriteLine("Start Thread N° : "+c);
        //    s.Wait();
        //    Console.WriteLine("Thread En travail : "+c);
        //    Thread.Sleep(6000);
        //    Console.WriteLine("Fin du travail : " + c);
        //    s.Release();
        //}
    }
}
 