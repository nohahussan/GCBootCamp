using System;
using System.Globalization;

namespace Deliverable1
{
    class CurrencyFormatConvertor
    {
        public static void Main(string[] args)
        {
            //declear an array to store the user inputs

            double[] arrayOfAmounts = new double[3];

            //declear variables 

            double total = 0;
            double average;
            double largestAmount;
            double smallestAmount;

            // take three diferent amount

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Please enter an amount : ");


                string input = Console.ReadLine();

                arrayOfAmounts[i] = Convert.ToDouble(input);

                total += arrayOfAmounts[i];
            }

            //calculate the average
            average = total / 3;

            //to find the largest amount and the smalest amount

            largestAmount = arrayOfAmounts[0];

            smallestAmount = arrayOfAmounts[0];

            for (int i = 1; i < arrayOfAmounts.Length; i++)
            {
                if(largestAmount < arrayOfAmounts[i])
                {
                    largestAmount = arrayOfAmounts[i];
                }

                if (smallestAmount > arrayOfAmounts[i])
                {
                    smallestAmount = arrayOfAmounts[i];
                }
            }

            //output the average ,largest and smallest amount

            Console.WriteLine("The Average : " + average);

            Console.WriteLine("The Largest amount : "+ largestAmount);

            Console.WriteLine("The Smallest amount : " + smallestAmount);


            //output the Total

            Console.WriteLine("US: "+ total.ToString("C2", CultureInfo.CreateSpecificCulture("es-US")));

            Console.WriteLine("Swedich: " + total.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE")));

            Console.WriteLine("Japanese: "+ total.ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP")));

            Console.WriteLine("Thai: "+ total.ToString("C2", CultureInfo.CreateSpecificCulture("th-TH")));

        }
    }
}
