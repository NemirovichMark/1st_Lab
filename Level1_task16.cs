using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 task 16
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal s=0, pow=1;
            for(int i=0; i<64; i++){
                s+=pow;
                pow*=2;
            }
            Console.WriteLine("Result is: {0}",s);
            Console.WriteLine("Result obtained with 100% accuracy");
        }
    }
}
