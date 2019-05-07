using System;
using System.Collections.Generic;
using System.Text;

namespace CoursSharp
{
    public class NegativeValueException : Exception
    {
        private string messageSpec;
        public NegativeValueException() : base("Valeur négative merci de corriger")
        {

        }

        public NegativeValueException(string m)
        {
            MessageSpec = m;
        }

        public string MessageSpec { get => messageSpec; set => messageSpec = value; }
    }
}
