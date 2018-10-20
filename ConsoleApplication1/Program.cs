using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░");
            Console.WriteLine("░░▓▓▓▓▓▓▓▓▓░▓▓▓▓▓▓▓▓▓░░");
            Console.WriteLine("░░░▓▓▓▓▓▓▓░░░▓▓▓▓▓▓▓░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░▓▓▓░▓▓▓░░░░░░░░");
            Console.WriteLine("░▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░");
            Console.WriteLine("░░▓▓▓▓▓▓▓▓▓░▓▓▓▓▓▓▓▓▓░░");
            Console.WriteLine("░░░▓▓▓▓▓▓▓░░░▓▓▓▓▓▓▓░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░");




            #region task1
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 1");

            Console.WriteLine("░░░░░░░░░░");
            Console.WriteLine("░░░░▓▓░░░░");
            Console.WriteLine("░░░▓▓▓▓░░░");
            Console.WriteLine("░░▓▓▓▓▓▓░░");
            Console.WriteLine("░▓▓░▓▓░▓▓░");
            Console.WriteLine("░▓▓▓▓▓▓▓▓░");
            Console.WriteLine("░░░▓░░▓░░░");
            Console.WriteLine("░░▓░▓▓░▓░░");
            Console.WriteLine("░▓░▓░░▓░▓░");
            Console.WriteLine("░░░░░░░░░░");
            #endregion




            #region task2
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 2");
            int numbera, numberb;
            Console.WriteLine("Please enter number a: ");
            numbera = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b: ");
            numberb = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + (numbera + numberb));
            Console.WriteLine("a - b = " + (numbera - numberb));
            Console.WriteLine("a * b = " + (numbera * numberb));
            Console.WriteLine("a / b = " + (numbera / numberb));
            #endregion




            #region task3
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 3");
            int a = 10, b = 2;
            int x = (a + b) / b;
            Console.WriteLine("a = 10 , b = 2");
            Console.WriteLine("x = (a + b) /b ");
            Console.WriteLine("x = " + x);
            #endregion




            #region task4
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 4");
            int n_a = 11, n_b = 2;
            double n_x = (10 + n_a + (Math.Pow(n_b, 10)) )/Math.Sqrt(n_a-n_b);
            Console.WriteLine("x = " + n_x);
            #endregion




            #region task5
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 5");
            int c = 7;
            if (c > 0)
            {
                c++;
                Console.WriteLine("Our number is " + c);
            }
            else Console.WriteLine("Our number is " + c);
            #endregion




            #region task6
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 6");
            int d = -8;
            if (d > 0)
            {
                d++;
            }
            else if (d < 0)
            {
                d = d - 2;
            }
            else if(d==0)
            {
                d=10;
            }
            Console.WriteLine("Our number is " + d);
            #endregion




            #region task7
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 7");
            int e = 2, f = 3;
            if (e>f) Console.WriteLine("Bigger number is " + e);
            else if (f>e) Console.WriteLine("Bigger number is " + f);
            else if (f==e) Console.WriteLine("The numbers are equal");
            #endregion




            #region task8
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 8");
            int A=6, B=9;
            if(A!=B)
            {
                A = A + B;
                B = A;
                Console.WriteLine("Number A is " + A);
                Console.WriteLine("Number B is " + B);
            }
            else if (A==B)
            {
                A = 0;
                Console.WriteLine("Number A is " + A);
                B = 0;
                Console.WriteLine("Number B is " + B);
            }
            #endregion




            #region task9
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 9");
            int n_A = 16, n_B = 26;
            int count = 0;
            for (int i = n_A; i <= n_B; i++)
            {
                Console.WriteLine(i);
                count++;
            }
            Console.WriteLine("The amount of numbers is " + count);
            #endregion




            #region task10
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 10");
            int num_A = 10, num_B = 36;
            int num_count = 0;
            for (int i = num_B-1; i > num_A; i--)
            {
                Console.WriteLine(i);
                num_count++;
            }
            Console.WriteLine("The amount of numbers is " + num_count);
            #endregion




            #region task11
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 11");
            int number_A = 12, number_B = 16;
            double sum = 0;
            for (int i = number_A; i < number_B; i++)
            {
                sum = sum + Math.Pow(i, 2);
            }
            Console.WriteLine("Sum = " + sum);
            #endregion




            #region task12
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Task 12");
            int N = 27;
            int K;
            for (int i = 0;; i++)
            {
                if (i * 3 > N)
                {
                    K = i;
                    Console.WriteLine("This number is " + K);
                    break;
                }
            }
            #endregion




            Console.ReadLine();
        }
    }
}
