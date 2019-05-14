using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Address
    {
        private string adresse;
        private string ville;
        private string codePostal;
        private IContactable contact;

        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }

        public Address(IContactable c)
        {
            contact = c;
        }
    }
}
