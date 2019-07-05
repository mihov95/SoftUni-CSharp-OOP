using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Hotel_Reservation
{
    public class PriceCalculator
    {
        public double pricePerDay { get; set; }
        public int numberOfDays { get; set; }
        public Seasons season { get; set; }
        public Enum discountType { get; set; }


        public static double GetTotalPrice(double pricePerDay, 
            int numberOfDays, 
            Enum season, 
            Enum discountType)
        {
            var result = pricePerDay * numberOfDays;

            switch (season)
            {
                case "Autumn":
                    result *= 1;
                    break;
            }
            
        }

    }
}
