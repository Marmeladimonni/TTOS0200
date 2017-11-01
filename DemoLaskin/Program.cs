using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Laskin
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
    }

    public class MyCalculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Testataan omalaskin
            MyCalculator laskin = new MyCalculator();
            int luku1 = 10;
            int luku2 = 20;
            Console.WriteLine("lukujen {0} ja {1} summa on {2}", luku1, luku2, laskin.Add(luku1, luku2));
        }
    }
}
