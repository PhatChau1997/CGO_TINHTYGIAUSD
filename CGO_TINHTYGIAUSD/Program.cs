using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TINHTYGIAUSD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usd;
            int a;
            a = 23000;
                       Console.Write("nhap so usd muon doi :");
            usd = float.Parse(Console.ReadLine());

            float vnd = usd * a;
            Console.WriteLine("so tien vnd cua ban la:" + vnd ); 
            Console.ReadLine();
        }
    }
}
