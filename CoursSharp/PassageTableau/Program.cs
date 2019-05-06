using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PassageTableau
{
    class Program
    {
        static string[] stagiaires = { "abdel", "fabien", "jf", "mohammed", "alexandreD", "olivier", "remi", "hamed", "selim", "andrew", "vincent", "xavier", "alexandreM", "jimmy" };
        static List<string> dejaPasse = GetFromFile();

        static void Main(string[] args)
        {
            string choix;
            do
            {

                Console.WriteLine("1- choissir un element");
                Console.WriteLine("2- Déja passé");
                Console.WriteLine("0-Quitter");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        string nom;
                        do
                        {
                            nom = GetElement();
                        } while (TestExist(nom));

                        Console.WriteLine(nom);

                        Console.Write("Valider ? : ");
                        string c = Console.ReadLine();
                        if (c == "oui")
                        {
                            dejaPasse.Add(nom);
                            SaveFile();
                            if (dejaPasse.Count == stagiaires.Length)
                            {
                                dejaPasse = new List<string>();
                                SaveFile();
                            }
                        }

                        break;
                    case "2":
                        Console.Clear();
                        foreach(string e in dejaPasse)
                        {
                            Console.Write(e + " ");
                            
                        }
                        Console.WriteLine("");
                        break;
                }
            } while (choix != "0");
        }

        static List<string> GetFromFile()
        {
            List<string> res = new List<string>();
            if (File.Exists("passage.txt"))
            {
                StreamReader r = new StreamReader("passage.txt");
                string contenu = r.ReadToEnd();
                r.Close();
                res = JsonConvert.DeserializeObject<List<string>>(contenu);
            }
            return res;
        }

        static bool TestExist(string nom)
        {
            bool exist = false;
            foreach (string e in dejaPasse)
            {
                if (e == nom)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        static void SaveFile()
        {
            StreamWriter w = new StreamWriter("passage.txt");
            w.Write(JsonConvert.SerializeObject(dejaPasse));
            w.Close();
        }

        static string GetElement()
        {
            Random r = new Random();
            int index = r.Next(0, stagiaires.Length - 1);
            return stagiaires[index];
        }

    }
}
