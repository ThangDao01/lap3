using System;

namespace Part4ex2
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public long sin { get; set; }
        public double salary { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public double CalculateBonus(double percentage)
        {
            return salary * percentage;
        }
        public override string ToString()
        {
            string str = $"firstName :{firstName} \n" +
                         $"lastName : {lastName} \n" +
                         $"address: {address} \n" +
                         $"sin: {sin} \n" +
                         $"salary {salary} \n";
            return str;
        }
    }
}