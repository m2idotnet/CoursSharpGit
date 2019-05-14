using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Employe : IContactable
    {
        private string nom;
        private string prenom;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
