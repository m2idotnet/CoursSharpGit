using System;
using System.Collections.Generic;
using System.Text;

namespace CoursSharp
{
    public class Voiture
    {
        private string model;
        private decimal price;

        public string Model { get => model; set => model = value; }
        public decimal Price { get => price; set {
                if (value > 0)
                    price = value;
                else
                    //throw new Exception("Prix incorrect");
                    throw new NegativeValueException("Message spec");
            }
        }
        public event Action<decimal> Promo;


        public void AppliquerPromotion(decimal montant)
        {
            Price -= montant;
            if(Promo != null)
            Promo(Price);
        }
    }
}
