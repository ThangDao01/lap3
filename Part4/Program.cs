using System;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int index = 0;
            int max = 10;
            var atoms = new Atom[10];
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            while (index != max)
            {
                Atom atom = new Atom();
                bool check = atom.accept();
                if (check)
                {
                    atoms[index] = atom;
                    index++;
                }else if (atom.number == 0)
                {
                    break;
                }
            }
            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < index; i++)
            {
                atoms[i].display();
            }
        }
    }
}