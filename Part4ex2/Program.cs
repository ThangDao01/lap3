using System;

namespace Part4ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Nguyen ","Van A","Bac Cuc",123456789,10000);
            Console.WriteLine("Salary Bonus :"+employee.CalculateBonus(0.2));
            Console.WriteLine(employee.ToString());
        }
    }
}