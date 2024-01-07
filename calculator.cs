using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class calculator
    {
    public void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("adition is : {0}", sum);
        }

        public void Sub(int num1, int num2)
        {
            int diff = 0;

            if (num1 >= num2)
            {
                diff = num1 - num2;
            }
            else if (num1 <= num2)
            {
                diff = num2 - num1;
            }
            Console.WriteLine("Subtraction of {0} - {1} = {2}", num1, num2, diff);
        }
        public void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication of {0} x {1} = {2}", num1, num2, num1 * num2);
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("Division of {0} / {1} = {2}", num1, num2, num1 / num2);
        }

    }

}
