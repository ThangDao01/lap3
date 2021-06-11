using System;

namespace Part4
{
    public class Atom
    {
        public int number { get; set; }
        public string symbol { get; set; }
        public string fullname { get; set; }
        public float weight { get; set; }

        public Boolean accept()
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter atomic number :");
                    if (int.TryParse(Console.ReadLine(), out var numTest))
                    {
                        number = numTest;
                        if (number == 0)
                        {
                            return false;
                        }

                        break;
                    }
                }

                Console.Write("Enter symbol :");
                symbol = Console.ReadLine();
                Console.Write("Enter full name :");
                fullname = Console.ReadLine();
                Console.Write("Enter atomic weight");
                while (true)
                {
                    Console.Write("Enter atomic number :");
                    if (float.TryParse(Console.ReadLine(), out var numTest))
                    {
                        weight = numTest;
                        break;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public void display()
        {
            Console.WriteLine($"{number} {symbol} {fullname} {weight}");
        }
    }
}