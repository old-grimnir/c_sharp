/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143
*/

// quick solution:
// count from 1 to target, checking for factors which are prime
// add each prime factor to a list
// find product of list
// if product = target, last prime added is highest



using System;
using System.Collections.Generic;

namespace euler3name
{
	class euler3
	{
		static Boolean primefunc(int target) // method defined BEFORE main
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

		public static void Main()
		{
			long num = 600851475143;
			List<long> pflist = new List<long>();  // list to store prime factors
			long prod = 1;  // var to store product of prime factors
			for (int i = 1; i < num; i++) // count to 600 billion or so
			{
				if (num % i == 0)  // check if current number is a factor
				{
					if (primefunc(i) == true)  // if it is, is it prime
					{
						pflist.Add(i); // if prime add to a list
						prod = 1;  // temporary storage for current product of prime factor list
						foreach (var m in pflist) { prod *= m; }  // multiply list contents together
					}
				}
				if (prod == num)  // if product of list equals our target, we have highest prime factor
				{
					Console.WriteLine("done");
					Console.WriteLine(i);
					return;
				}
			}
		}
	}
}
