using System;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region Easy
            Console.WriteLine("--------- I ---------");
            #region I_№4
            Console.WriteLine("№4");

            double answ = 0.0;
            int x = 0;
            while (x == 0)
            {
                Console.WriteLine("Enter x");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Error");
                }
            }
            for(int i = 1; i <= 9; i++)
            {
                answ = answ + Math.Cos(x*i) / Math.Pow(x, i - 1);
            }
            Console.WriteLine($"Answer: {answ}");
            Console.WriteLine("--------------------");

            #endregion

            #region I_№9
            Console.WriteLine("№9");

            answ = 0.0;
            int f = 1;
            for(int i = 1; i <=6 ; i++)
            {
                f = f*i;
                answ = answ + Math.Pow(-1, i) * Math.Pow(5, i) / f;
            }
            Console.WriteLine($"Answer: {answ}");
            Console.WriteLine("--------------------");
            #endregion
            
            #region I_№15
            Console.WriteLine("№15");

            answ = 0.0;
            double chisl1 = 1;
            double chisl = 2;
            double znam1 = 1;
            double znam = 1;
            for (int i = 3; i <=5 ; i++)
            {
                chisl = chisl1 + chisl;
                chisl1 = chisl - chisl1;
                znam = znam1 + znam;
                znam1 = znam - znam1;
            }

            Console.WriteLine($"Answer: {chisl/znam}");
            Console.WriteLine("--------------------");

            #endregion

            #region I_№16
            Console.WriteLine("№16");

            answ = 1.0;
            for (int i = 1; i <= 64; i++)
            {
                answ = answ*2;
            }

            Console.WriteLine($"Answer: {answ*15/1000000} T");
            Console.WriteLine("--------------------");

            #endregion

            #region I_№18
            Console.WriteLine("№18");
            
            answ = 10;
            for (int i = 1; i <= 8; i++)
            {
                answ = answ*2;
            }

            Console.WriteLine($"Answer: {answ}");
            Console.WriteLine("--------------------");

            #endregion

            #endregion

            #region II
            Console.WriteLine("--------- II ---------");

            #region II_№2
            Console.WriteLine("№2");

            answ = 1.0;
            double p = 1.0;

            while (p < 30000)
            {
                answ = answ + 3;
                p = p * answ;
            }
            answ = answ - 3;
            Console.WriteLine($"Answer: {answ}");
            Console.WriteLine("--------------------");

            #endregion
            
            #region II_№4
            Console.WriteLine("№4");

            double Input(double n)
            {
                if (Math.Abs(n) < 1)
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Enter x (|x| < 1):");
                    return Input(Convert.ToDouble(Console.ReadLine()));
                }
            }

            Console.WriteLine("Enter x (|x| < 1):");
            p = Input(Convert.ToDouble(Console.ReadLine()));
            answ = 1.0;
            int q = 0;
            while(Math.Pow(p, q) >= 0.0001)
            {   
                q = q + 2;
                answ = answ + Math.Pow(p, q);
            }
            answ = answ - Math.Pow(p, q);
            
            Console.WriteLine($"Answer: {answ}");
            Console.WriteLine("--------------------");

            #endregion
            
            #region II_№7_№8
            Console.WriteLine("№7, №8");
            
            double s = 10;
            double last = 10;
            for (int i = 1; i <= 7; i++)
            {
                
            }
            
            Console.WriteLine($"Answer a): {s}");

            s = 10;
            last = 10;
            int day = 1;
            while(s < 100)
            {
                last = last*1.1;
                s = last + s;
                day = day + 1;
            }

            Console.WriteLine($"Answer b): {day}");

            s = 10;
            last = 10;
            day = 1;
            while(last <= 20)
            {
                last = last*1.1;
                s = last + s;
                day = day + 1;
            }

            Console.WriteLine($"Answer v): {day}");
            Console.WriteLine("--------------------");


            #endregion

            #endregion

            #region III
            Console.WriteLine("--------- III ---------");

            #region III_№1
            Console.WriteLine("№1");
            
            for(double g = 0.1; g <= 1; g += 0.1)
            {
                int i = 0;
                int u = 1;
                double sum = 0.0;
                p = 1;
                while (p > 0.0001)
                {
                    u = u * (i*2) * ((i*2)- 1);
                    if (u == 0)
                    {
                        u = 1;
                    }
                    if (i % 2 == 0)
                    {
                        p = ((Math.Pow(g, 2*i))/u);
                    }
                    else
                    {
                        p = (-1)*((Math.Pow(g, 2*i))/u);
                    }
                    sum += p;
                    if (p < 0)
                    {
                        p = p * -1;
                    }
                    i++;
                }
                Console.WriteLine($"sum = {sum}; f({g}) = {Math.Cos(g)}");
            }
            Console.WriteLine("--------------------");

            #endregion

            #region III_№7
            Console.WriteLine("№7");
            
            for(double g = 0.1; g <= 1; g += 0.05)
            {
                const double e = 2.7182818284590452353602874713527;
                int i = 0;
                int u = 1;
                double sum = 0.0;
                p = 1;
                while (p > 0.0001)
                {
                    u = u * (i*2) * ((i*2)- 1);
                    if (u == 0)
                    {
                        u = 1;
                    }
                    p = ((Math.Pow(g, 2*i))/u);
                    sum += p;
                    i++;
                }
                Console.WriteLine($"sum = {sum}; f({g}) = {(Math.Pow(e, g) + Math.Pow(e, (-g))/2)}");
            }

            #endregion

            #endregion

        }
    }
}