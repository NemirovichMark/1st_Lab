using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 task 9
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,pow1=-1,pow2=5;
            for(int i=1; i<=6; i++){
                s+=pow1*pow2/i;
                pow1*=-1;
                pow2*=5;
            }
            Console.WriteLine(s);
        }
    }
}
