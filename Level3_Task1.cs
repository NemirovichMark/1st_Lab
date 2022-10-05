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
            for(double x=a;x<=b;x+=h){
                sum=0;
                meat=1;
                y=0;
                int fact=1;
                for(int i=0;abs(meat)>=0.0001;i++){
                    meat=Math.Pow(-1,i)*Math.Pow(x,2*i)/fact;
                    fact*=(2*i-1)*2*i;
                    sum+=meat;
                }
                y=Math.Cos(x);
                Console.WriteLine($"X: {x}, S: {sum}, Y: {y}");
            }
        }
        static double abs(double n){
            if(n>0) return n;
            return -1*n;
        }
    }
}
