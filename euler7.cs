// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
// we can see that the 6th prime is 13.
// What is the 10 001st prime number?
// answer: Problem 007: 104743

using System;

namespace euler7name {
   class euler7 {
      static Boolean primefunc(int target)
		{
			if (target <= 1) return false; // 1 is not prime
			if (target == 2) return true; // 2 is prime
			if (target % 2 == 0) return false; // evens arent prime
			var boundary = (int)Math.Floor(Math.Sqrt(target));
			for (int i = 3; i <= boundary; i+=2)
			{
				if (target % i == 0) return false;
			} 
			return true; // final catch
		}
      
      static void Main() 
      {
         bool done = false;
         int i = 1;
         int pcount = 0;
         while (!done)
         {
            if (primefunc(i))
            {
               pcount += 1;
               if (pcount == 10001)
               {
                  Console.WriteLine(i);  
                  done = true;       
               }
            }
            i++;
         }
      }
   }
}