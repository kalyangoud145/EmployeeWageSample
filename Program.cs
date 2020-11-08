using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Constants
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int WAGE_PER_HR = 20, TOTAL_HRS_IN_A_DAY = 8;
            int totalEmployeeWage;

            Random random = new Random();
            int empCheck = random.Next(2);
            ///Checks if employee is present, if present it will print
            ///employee present if condition fails it prints employee absent
            if (empCheck == IS_EMPLOYEE_FULL_TIME)
            {
                totalEmployeeWage = WAGE_PER_HR * TOTAL_HRS_IN_A_DAY;
                Console.WriteLine("Employee present and daily wage is: " + totalEmployeeWage); 
            }
            else
            {
                Console.WriteLine("Employee absent ");
            }
        }
    }
}
