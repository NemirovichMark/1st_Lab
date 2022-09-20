    
    
using System;
class HelloWorld {
  static void Main() {
    string vvod = Console.ReadLine();
    double x = Convert.ToInt32(vvod); //вводим градусы
    if (x==0) {Console.WriteLine("x cannot be equal to zero");}
    else {
    double sum=0;
    x=x*0.0175; //переводим в радианы
    for (int i=0; i<9; i++)
    {
        sum=sum+Math.Cos(x*(i+1))/Math.Pow(x,i);
    }
    Console.WriteLine(sum);
    }
  }
}
