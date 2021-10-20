using System;

namespace _20._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            uint i, j;
            uint[,] A = new uint[5, 5]{ { 25 , 55 , 15 , 75 , 255 } ,
     { 7525 , 1715 , 2525 , 71515 , 555 } ,
     { 20 , 50 , 700 , 800 , 1000 } ,
     { 22 , 72 , 92 , 32 , 102 } ,
     { 73  , 883 , 353 , 703 , 2283 }
   };
            for (i = 0; i <= (5 - 1); i++)
            {
                uint sum = 0;
                for (j = 0; j <= (5 - 1); j++)
                {
                    sum += A[i, j];
                }
                Console.WriteLine(sum+ "\n\n");
            }
            Console.ReadLine();
        }
    }
}
