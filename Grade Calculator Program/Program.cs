/* Prgram Name:Grade Calculator Program
 * Developer:Zih Hao Huang
 * Date:15/09/2022
 * Algorithm
 * 1,Ask the user to input marks for 4 subjects (Maths, Physics, Chemistry and Computer Science) out of a maximum of 100
 * 2.Use a function to calculate the average of the 4 marks and return it
 * 3.Use a function to find out the grade of the student using the average marks following the criteria listed below
    • Marks >= 80 – Grade A
    • Marks >=70 and < 80 – Grade B
    • Marks >=60 and <70 – Grade C
    • Marks>=50 and <60 – Grade D
    • Marks <50 – Grade F
 * 4.Using a switch statement, print remarks listed below based on the grade
    • Grade A – ‘Excellent! Your grade is A’
    • Grade B – ‘Good! Your grade is B’
    • Grade C – ‘Satisfactory. Your grade is C’
    • Grade D – ‘Pass. Your grade is D’
    • Grade F – ‘Fail. Your grade is F’
 */
using System;

namespace Grade_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method that gets values from user
            GetFourValues();
            Console.ReadKey();
        }
        public static int FourNumberAdding(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        static int ValidateNumber()
        {
            int count = 1, num = 0;
            try
            {
                //when condition is num > 100 || num < 0 will be true and pass
                do
                {
                    if (count <= 3)
                    {
                        if (count == 1)
                        {
                            num = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Please check and try a valid number (0-100):");
                            num = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have used 3 attempts - so I am assign number = 0:");
                        num = 0;
                        break;
                    }
                    count++;
                } while (num > 100 || num < 0);
            }
            catch (Exception error) { Console.WriteLine(" Systeam error Please cheack input", error); }
            return num;
        }
        static void GetFourValues()
        {
            // Declaration of Variables
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5;
            // Ask user to enter value1 & Store in a variable
            Console.WriteLine("Please enter mark of Maths:");
            num1 = ValidateNumber();
            // Ask user to enter value2 & Store in a variable
            Console.WriteLine("Please enter mark of Physics:");
            num2 = ValidateNumber();
            // Ask user to enter value3 & Store in a variable
            Console.WriteLine("Please enter mark of Chemistry:");
            num3 = ValidateNumber();
            // Ask user to enter value4 & Store in a variable
            Console.WriteLine("Please enter mark of Computer Science:");
            num4 = ValidateNumber();
            // calling the method by passing arugments
            num5 = FourNumberAdding(num1, num2, num3, num4) / (4);
            Console.WriteLine("Addition of four mark is:{0}", num5);
            ShowRemarks(num5);
        }

        static string GetGrade(float num5)
        {
            if (num5 >= 80)
            {
                return "A";
            }
            if (num5 >= 70 && num5 < 80)
            {
                return "B";
            }
            if (num5 >= 60 && num5 < 70)
            {
                return "C";
            }
            if (num5 >= 50 && num5 < 60)
            {
                return "D";
            }
            if (num5 < 50)
            {
                return "F";
            }
            return "F";
        }
        static void ShowRemarks(float grade)
        {
            switch (GetGrade(grade))
            {
                case "A":
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case "D":
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;
            }
        }
    }

}
