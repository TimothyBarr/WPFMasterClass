using System;
using CSharpPartice.Classes;
using CSharpPartice.FileIO;
using CSharpPartice.Interfaces;

namespace CSharpPartice
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Main,,,

            // myMessage group
            var myMessage1 = "this is message 1";
            Console.WriteLine(myMessage1);

            // write and int
            var anInt = 61;
            Console.WriteLine(anInt);

            // use static MySimpleMath.Add funtion
            double simpleMath = MySimpleMath.Add(anInt, anInt);


            // use static MySimpleMath.Add override for an array
            double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            var myAddOverRide = MySimpleMath.Add(numbers);
            Console.WriteLine(myAddOverRide);

            ChildBankAccount childBankAccount = new ChildBankAccount();
            childBankAccount.AddToBalance(100);
            var simpleMathMessage = Information(childBankAccount) + simpleMath;
            Console.WriteLine(simpleMathMessage);

            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(100);
            Console.WriteLine(Information(bankAccount));

            MyInformation myInformation = new MyInformation();

            Console.WriteLine("Hello World!");

            #endregion
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }

    class MySimpleMath : IInformation
    {
        #region MySimpleMath...

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Add(double[] myArray)
        {
            double result = 0;
            foreach (double d in myArray)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return $"This is the MySimpleMath ";
        }

        #endregion
    }
}