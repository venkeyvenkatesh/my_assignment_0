using System;

namespace Assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Employee");


            int IS_FULLTIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if(empCheck==IS_FULLTIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Emp Wage :" + empWage);
         
        }
    }
}
