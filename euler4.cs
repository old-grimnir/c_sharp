/*A palindromic number reads the same both ways. 
The largest palindrome made from the product of 
two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product 
of two 3-digit numbers. */

using System;

namespace euler4name 
{
   class euler4
   {
      static int revnum(int target)  // math trickery to reverse a number (ditches leading zeroes tho)
		{
			int sum = 0;
         int result = 0;
         while(target>0)
         {
            result = target % 10;
            sum = (sum * 10) + result;
            target = target / 10;
         }
			return sum;
		}
      
      static void Main()  
      {
      int temp = 0;
      int temp2 = 0;
      int sol = 0;
      int prod1 = 0;
      int prod2 = 0;
      for (int i = 100; i < 1000; i ++)  // from low to high loop1
      {
         for (int j = 100; j < 1000; j++) // from low to high loop2
         {
            temp = i * j;  // multiple the numbers
            temp2 = revnum(temp);  // check product is palindrome
            if (temp == temp2)  // if so
            {
               if (temp > sol)  // if it is the largest we've seen, store it
               {
                  sol = temp; // stored here
                  prod1 = i;  // along with numbers multiplied
                  prod2 = j;  // to reach target
               }
            }
         }
      }
      Console.WriteLine(sol);
      Console.WriteLine(prod1);
      Console.WriteLine(prod2);    
      }
   }
}