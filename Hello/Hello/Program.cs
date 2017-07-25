using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Damir!");
            // Comments for new commit.
            Console.WriteLine("Input string:");
            var str = Console.ReadLine();
            Console.WriteLine(string.Format("Your string {0}", str));
            Console.ReadLine();

            // Dev branch
            Console.WriteLine("Dev branch");
            Console.ReadLine();
        }
    }
}
