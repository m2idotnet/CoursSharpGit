using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOrdinateur ordinateur;
            //Console.Write("Protable ou fixe ? : ");
            //string choix = Console.ReadLine();
            //if(choix == "p")
            //{
            //    ordinateur = new OrdinateurPortable(); 
            //}
            //else
            //{
            //    ordinateur = new OrdinateurFixe();
            //}

            //CarteGraphique  cg = ordinateur.CreerCarteGraphique("m1", "1GO", "NVIDEA");
            //CarteMere cm = ordinateur.CreerCarteMere("ASUS", "LG5511");
            //Console.WriteLine(cg.Afficher());
            //Console.WriteLine(cm.Afficher());
            IContactable e1 = new Employe();
            Address a1 = new Address(e1);
            IContactable e2 = new Entreprise();
            Address a2 = new Address(e2);
            Console.ReadLine();
        }
    }
}
