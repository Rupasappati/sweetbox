// See https://aka.ms/new-console-template for more information

namespace calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            calculator objCalc = new calculator();
            Console.WriteLine("enter 1st number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd number = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            objCalc.Addition(num1, num2);
            objCalc.Sub(num1, num2);
            objCalc.Mul(num1, num2);
            objCalc.Div(num1, num2);

        }
    }

}