using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_EMPLOYEE_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_EMPLOYEE_FULL_TIME)
            {
                Console.WriteLine("Employee present");
            }
            else
            {
                Console.WriteLine("Employee absent");
            }
        }
    }
}
