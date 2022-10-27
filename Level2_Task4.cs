using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 2 Task 4
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,x=double.Parse(Console.ReadLine()),pow=1;
            for(int n=0; pow>=0.0001;n+=2){
                s+=pow;
                Console.WriteLine($"n: {n} S: {s}");
                pow*=(x*x);
            }
        }
    }
}
