using System;

namespace IntegerToBinaryStack
{
    class Program
    {
        static void Main(string[] args)
        {

            CStack stk = new CStack();
            string number;

            Console.Write("Enter the integer : ");

            number = Console.ReadLine();

            int num = Convert.ToInt32(number);
     
            stk.intToBin(num);

        }




    }
}
