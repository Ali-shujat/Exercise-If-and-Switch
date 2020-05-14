using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. SWITCH!");
            Console.WriteLine("Please enter a numerical mark");
            var num = Convert.ToInt32(Console.ReadLine());

            #region Uning If statement 
            if (num == 9 || num == 10)
            {
                Console.WriteLine("Exellent");
            }
            else if (num == 7 || num == 8)
            {
                Console.WriteLine("Notable");
            }
            else if (num == 6)
            {
                Console.WriteLine("Good");
            }
            else if (num == 5)
            {
                Console.WriteLine("Pass");
            }
            else if (num <= 4)
            {
                Console.WriteLine("Fail");
            }

            #endregion

            #region Using Switch

            switch (num)
            {
                case 0:
                    Console.WriteLine("FAIL");
                    break;
                case 1: goto case 0;
                case 2: goto case 0;
                case 3: goto case 0;
                case 4: goto case 0;
                case 5:
                    Console.WriteLine("PASS");
                    break;
                case 6:
                    Console.WriteLine("GOOD");
                    break;
                case 7:
                    Console.WriteLine("NOTABLE");
                    break;
                case 8: goto case 7;
                case 9:
                    Console.WriteLine("EXELLENT");
                    break;
                case 10: goto case 9;
                default:
                    Console.WriteLine("OUT OF RANGE");
                    break;
            }

            #endregion


            Console.ReadKey();

        }
    }
}
