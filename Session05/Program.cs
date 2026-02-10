using Common;

namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"X + Y = {0}");

            //string str;
            //str = new string("ahmed");


            //Nullable<double> baseSalary = null;
            //double netSalary;
            //if (baseSalary.HasValue)
            //{
            //    netSalary = baseSalary.Value * 1.1;
            //    Console.WriteLine(netSalary);
            //}
            //else
            //{
            //    netSalary = default;
            //    Console.WriteLine("No salary!");
            //}

            //netSalary = (baseSalary ?? 0) * 1.1;
            //Console.WriteLine(netSalary);

            //int[] arr = {1, 2, 3, 4, 5};

            //arr = null;
            //Console.WriteLine(arr?.Length);


            Class1 c1 = new Class1();
            Console.WriteLine(c1.x);

        }
    }
}
