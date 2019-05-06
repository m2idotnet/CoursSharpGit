using System;
using System.Collections.Generic;
using System.Text;

namespace CoursSharp
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException() : base("Valeur négative merci de corriger")
        {

        }
    }
}
