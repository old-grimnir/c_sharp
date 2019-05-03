
// The sum of the squares of the first ten natural numbers is,
// 1*1 + 2*2 + ... + 10*10 = 385
// The square of the sum of the first ten natural numbers is,
// (1 + 2 + ... + 10)*(1 + 2 + ... + 10) = 55*55 = 3025
// Hence the difference between the sum of the squares of the 
// first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the 
// first one hundred natural numbers and the square of the sum.
// answer: Problem 006: 25164150

using System;

namespace euler6name {
   class euler6 {
      static void Main() {
         int sumsq = 0;
         for (int i = 1; i < 101; i++)
         {
            sumsq += (i * i);
         }
         //Console.WriteLine(sumsq);

         int sqsum = 0;
         for (int j = 1; j < 101; j++)
         {
            sqsum += j;
         }
         sqsum = sqsum * sqsum;
         //Console.WriteLine(sqsum);
         
         int answerdif = 0;
         answerdif = (sqsum - sumsq);

         Console.WriteLine(answerdif);
      }
   }
}