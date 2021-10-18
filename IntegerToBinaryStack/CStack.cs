using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerToBinaryStack
{
   public class CStack
    {

		public void intToBin(int number)
		{
			Stack<int> stk = new Stack<int>();
			while (number > 0)
			{
				int rem = number % 2; //take remainder
				number = number / 2;
				stk.Push(rem);
			}
			while (stk.Count > 0)
			{
				int item;
				item = stk.Peek();
				stk.Pop();
				Console.Write(item);
			}
		}

	}
}
