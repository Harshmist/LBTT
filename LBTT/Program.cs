using System;

namespace LBTT
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Find value of the property and save
            Console.WriteLine("What is the value of the property?");
             double propVal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your tax is: £" + Convert.ToString(CalculateTax(propVal)));
        }

        public static double CalculateTax(double propVal)
        {
            //These are the max amounts of tax per bracket. I've worked these out seperately and placed in the array, however could have done this as e.g. ((Bracket2 - Bracket1)/100)*Bracket% at each index.
            double[] maxBracket = new double[] { 2100, 3750, 42500 };

            if (propVal <= 145000){
                return 0;
            }else if (propVal <= 250000){
                return (propVal - 145000) * 0.02;
            }else if (propVal <= 325000){
                return ((propVal - 250000) * 0.05) + maxBracket[0];
            }else if (propVal <= 750000){
                return ((propVal - 325000) * 0.1) + (maxBracket[0] + maxBracket[1]);
            }else{
                return ((propVal - 750000) * 0.12) + (maxBracket[0] + maxBracket[1] + maxBracket[2]);
            }
        }
      }
    }

