﻿using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

namespace _2nd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region Level 1
            #region Task 3
            Console.WriteLine("Task 3");
            double a, b, c;
            Console.WriteLine("enter the a value");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("enter the b value");
            double.TryParse(Console.ReadLine(), out b);
            if (a > 0)
            {
                c = a;
                if (b > a)
                    c = b;
            }
            else
            {
                c = a;
                if (b < a)
                    c = b;
            } Console.WriteLine(c);
            #endregion
            #region Task 4
            Console.WriteLine("Task 4");
            double a1, b1, c1, z, d;
            Console.WriteLine("enter the a value");
            double.TryParse(Console.ReadLine(), out a1);
            Console.WriteLine("enter the b value");
            double.TryParse(Console.ReadLine(), out b1);
            Console.WriteLine("enter the c value");
            double.TryParse(Console.ReadLine(), out c1);
            d = a1;
            if (b1 < a1)
                d = b1;
            z = c1;
            if (d > c1)
                z = d;
            Console.WriteLine(z);
            #endregion
            #endregion
            #region Level 2
            #region Task 1
            Console.WriteLine("Task 1");
            double hight, srhight, s = 0;
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the hight of the student ");
                double.TryParse(Console.ReadLine(), out hight);
                s += hight;
            }
            srhight = s / n;
            Console.WriteLine(srhight);
            #endregion
            #region Task 3
            Console.WriteLine("Task 3");
            int k = 7;
            double weight, glass = 200;
            double num = 0;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("enter the weight of the student");
                double.TryParse(Console.ReadLine(), out weight);
                num += 200;
                if (weight < 30)
                    num = num + glass;
            }
            num /= 1000;
            Console.WriteLine($"liters {num}");
            #endregion
            #endregion
            #region Level 3
            #region Task 4
            double r, R, x1, y1;
            int numb = 0;
            Console.WriteLine("Enter r");
            double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Enter R");
            double.TryParse(Console.ReadLine(), out R);
            if (R > r && R > 0)
            {
                do
                {
                    Console.WriteLine("enter the x value or '12345' to end");
                    double.TryParse(Console.ReadLine(), out x1);
                    if (x1 >= 12345)
                        break;
                    Console.WriteLine("enter the y value");
                    double.TryParse(Console.ReadLine(), out y1);
                    if ((x1 * x1 + y1 * y1 <= r * r) && (x1 * x1 + y1 * y1 <= R * R))
                        numb++;

                } while (true);
            }
            else
                Console.WriteLine("enter the correct data");
            Console.WriteLine(numb);
            #endregion
            #region Task 11
            int mark1, mark2, mark3, mark4, badstud= 0;
            double srball, stud,sumz=0;
            Console.WriteLine("Enter tne student's amount");
            double.TryParse(Console.ReadLine(), out stud);
            for (int i = 0; i < stud; i++)
            {
                Console.WriteLine("Enter the marks for the exams ");
                int.TryParse(Console.ReadLine(), out mark1);
                int.TryParse(Console.ReadLine(), out mark2);
                int.TryParse(Console.ReadLine(), out mark3);
                int.TryParse(Console.ReadLine(), out mark4);
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                {
                    badstud++;
                }
                else
                {
                    if (mark1 <= 5 && mark2<= 5 && mark3 <= 5 && mark4 <= 5 && mark1 > 2 && mark2 > 2 && mark3 > 2 && mark4 > 2)
                    {
                        sumz = sumz + mark1 + mark2 + mark3 + mark4;
                    }
                }


            }
            stud= stud - badstud;
            srball = stud / sumz;
            Console.WriteLine($"Group average: {srball}");
            Console.WriteLine($"Number of underachievers: {badstud}");
            #endregion
            #endregion
            #region Task 12
            Console.WriteLine("task 12");
            double Rad;
            int num12;
            Console.WriteLine("enter the R value");
            double.TryParse(Console.ReadLine(), out Rad);
            if (Rad > 0)
            {
                Console.WriteLine("choose what you want to count:(1) is the area of the square, (2) is the area of the circle,(3) is the area of an equilateral triangle");
                int.TryParse(Console.ReadLine(), out num12);
                switch (num12)
                {
                    case 1:
                        Rad *= Rad;
                        Console.WriteLine($"the area of the square={Rad}");
                        break;
                    case 2:
                        Rad = Math.PI * Rad * Rad;
                        Console.WriteLine($"the area of the circle={Rad}");
                        break;
                    case 3:
                        Rad = (Math.Pow(Rad, 2) * Math.Sqrt(3)) / 4;
                        Console.WriteLine($"the area of an equilateral triangle={Rad}");
                        break;
                }

            }
            else
                Console.WriteLine("enter the correct data");
            #endregion
            #region Task 13
            Console.WriteLine("task 13");
            double A, B, S;
            int f;
            Console.WriteLine("Enter the A value");
            double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Enter the B value");
            double.TryParse(Console.ReadLine(), out B);
            if (A > 0 && B > 0)
            {
                Console.WriteLine(" if you want to count the area of the triangle press(1),ring area(2),the area of the triangle(3)");
                int.TryParse(Console.ReadLine(), out f);
                switch (f)
                {
                    case 1:
                        S = A * B;
                        Console.WriteLine($"area of the triangle={S}");
                        break;
                    case 2:
                        S = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                        Console.WriteLine($"ring area={S}");
                        break;
                    case 3:
                        double s13 = A / 2;
                        if (B < s13)
                            Console.WriteLine("Error");
                        else
                        {
                            double o = Math.Sqrt(B * B - s13 * s13);
                            S = (A * o) / 2;
                            Console.WriteLine($"the area of the triangle={S}");
                        }
                        break;
                }
            }
            else
                Console.WriteLine("enter the correct data ");
            #endregion
            












        }
    }
    
} 