using Newtonsoft.Json;
using System;
using System.IO;

namespace CoursSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ecrire votre texte : ");
            //string text = Console.ReadLine();
            //objet pour ecrire un flux dans fichier de type texte
            //StreamWriter writer = new StreamWriter(@"C:\Users\Administrateur\Desktop\fichier.doc");
            //writer.WriteLine(text);
            //writer.Close();

            //tester si un fichier existe
            //if(File.Exists(@"C:\Users\Administrateur\Desktop\fichier.doc")) {
            //    //Flux de lecture d'un fichier de contenu de type texte
            //    StreamReader reader = new StreamReader(@"C:\Users\Administrateur\Desktop\fichier.doc");
            //    string contenu = reader.ReadToEnd();
            //    Console.WriteLine(contenu);
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            Console.Write("Votre nom : ");
            string n = Console.ReadLine();
            Console.Write("Votre prénom : ");
            string p = Console.ReadLine();
            Personne perso = new Personne() { Nom = n, Prenom = p };
            //@ pour eviter d'echapper le back-slash
            StreamWriter writer = new StreamWriter(@"C:\Users\Administrateur\Desktop\personne.txt");
            //writer.WriteLine("Nom : " + perso.Nom);
            //writer.WriteLine("Prenom : " + perso.Prenom);
            //writer.Close();
            //newton json
            string persoEnJson = JsonConvert.SerializeObject(perso);
            writer.WriteLine(persoEnJson);
            writer.Close();
            StreamReader reader = new StreamReader(@"C:\Users\Administrateur\Desktop\personne.txt");
            string contenuFichier = reader.ReadToEnd();
            Personne p2 = JsonConvert.DeserializeObject<Personne>(contenuFichier);
            reader.Close();
            Console.WriteLine(p2.Nom + " " + p2.Prenom);
            Console.ReadLine();
        }
    }
}
