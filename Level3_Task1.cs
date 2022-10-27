using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0.1, b=1, h=0.1;
            double sum = 0, meat = 1, y=0;
            double pow,fact,i,sign;
            for(double x=a;x<=b;x+=h){
                sum=0;
                meat=1;
                y=0;
                sign = -1;
                pow=1;
                fact=1;
                i=0;
                do{
                    sign*=-1;
                    meat=sign*pow/fact;
                    sum+=meat;
                    pow*=(x*x);
                    y=Math.Cos(x);
                    i++;
                    fact*=(2*i*(2*i-1));
                }
                while(abs(meat)>=0.0001);
                y=Math.Cos(x);
                Console.WriteLine($"X: {x}, S: {sum}, Y: {y}");
            }
        }
        static double abs(double n){
            if(n>0) return n;
            return -n;
        }
    }
}
