using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitWareLib;
namespace EmployeeMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the total no of employee");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n];
            string[] w = new string[n];
            double[] f = new double[n];
            for (int d=0; d<n; d++)
            {
                Console.WriteLine("enter the "+(d+1)+"st Emplyoee  Number");
                q[d] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the " + (d + 1) + "st Emplyoee Name");
                w[d] = Console.ReadLine();
                Console.WriteLine("enter the "+(d+1)+ "st Emplyoee Salary");
                f[d] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int x = 0; x < n; x++)
            {
                Emplyoee e = new Emplyoee(q[x], w[x], f[x]);
                e.set(f[x]);
                e.get();
            }
            /*Emplyoee e = new Emplyoee(1,"balu",4000);
            e.set(5000);
            e.get();
            Emplyoee j = new Emplyoee(2, "raju", 6000);
            j.set(6000);
            j.get();
            Emplyoee u = new Emplyoee(3, "maccha", 14000);
            u.set(6000);
            u.get();
            Emplyoee r = new Emplyoee(4, "macchi", 25000);
            r.set(25000);
            r.get();
            */
            Console.ReadKey();

        }
    }
}
