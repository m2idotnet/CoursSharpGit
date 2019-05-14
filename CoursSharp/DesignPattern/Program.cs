using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrdinateur ordinateur;
            Console.Write("Protable ou fixe ? : ");
            string choix = Console.ReadLine();
            if(choix == "p")
            {
                ordinateur = new OrdinateurPortable(); 
            }
            else
            {
                ordinateur = new OrdinateurFixe();
            }

            CarteGraphique  cg = ordinateur.CreerCarteGraphique("m1", "1GO", "NVIDEA");
            CarteMere cm = ordinateur.CreerCarteMere("ASUS", "LG5511");
            Console.WriteLine(cg.Afficher());
            Console.WriteLine(cm.Afficher());
            Console.ReadLine();
        }
    }
}
