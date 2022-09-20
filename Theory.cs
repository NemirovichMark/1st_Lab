using System;
using System.Xml;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* #region Booleans
             bool truth = true, failure;
             failure = false;
             truth = 5 > 2;
             truth = (1 == 0) || ((1 > 0) && true);
             failure = !truth;

             // For better interface presentation you can use \t - tabulation, (variable, +-constant) - padding left and right respectively and \n - new line transition
             Console.WriteLine($"True is {truth,10}. \ttab adding\tfalse is {failure,-10}! \njump to next line");
             #endregion

             #region Loops

             #region Do
             // If you sure that at least 1 time process should be done, but you don't know how much times, use "do...while" 

             double age = 0.0;
             int counter = 0;
             Random randomMonthAdd = new Random(); // at the start of the program new sequence will be generated
             do
             {
                 var rand = randomMonthAdd.NextDouble(); // add random (pseudo-random) value between 0 and 1
                 age += rand;
                 counter++;

             } while (age < 18); // when condition will be executed the program will go ahead (down)
             Console.WriteLine($"{counter} in do cycle");

             #endregion

             #region While
             // If you don't know how much times the program should be repeated (but it can be zero), use "while"
             counter = 0;
             while (age < 25)
             {
                 age *= 1.01;
                 counter++;
             }
             Console.WriteLine($"{counter} in while cycle");

             #endregion

             #region For
             // If you know how much times the program should be repeated use "for"
             counter = 100;
             for (int i = 0; i < counter.ToString().Length; i += (2 * 1)) // condition can be number or function or empty, step can be any that type allow you
             {
                 age += i / 100.0; // if you want cast int to double, type number with .0 addition
                 counter -= i;
             }
             Console.WriteLine($"{counter} in for cycle");

             #endregion

             #region Foreach

             // when we have collections and operations don't include index, we can run over all collection with cycle "foreach"

             // to get string from any variable we can with method nameof
             // to get type specification from any type we can with method typeof
             // often it is better than use general strings that means name or type of the variable
             counter = 0;
             string variableName = nameof(counter);
             foreach (char letter in variableName)
             {
                 counter++;
             }
             Console.WriteLine($"{counter} in foreach cycle");

             #endregion

             #endregion

             #region Advices For Smart Students

             #region First advice: calculated condition
             // Make calculation in condition every time is bad practice (counter.ToString().Length contain above 20 lines of code actually).
             // so if calculation in the cycle don't make affect on condition, make it before start the cycle!
             counter = 0;
             var lengthOfWord = counter.ToString().Length;
             for (int i = 0; i < lengthOfWord; i += (2 * 2)) // condition can be number or function or empty, step can be any that type allow you
             {
                 age += i / 100.0; // if you want cast int to double, type number with .0 addition
                 counter++;
             }
             Console.WriteLine($"Read first advice above how to get counter = {counter}");

             #endregion

             #region Second advice: several conditions
             // If you have 2 or more conditions that allow you to leave the cycle or another program can stop your cycle, you can use "break" key word
             // or type all your conditions in the cycle declaration
             counter = 100;
             age = 0.0;
             while (counter > 0 || age < 100)
             {
                 age++;
                 counter--;
                 if ((int)age == counter)
                 {
                     break;
                 }
             }

             It can be helpful if you use "eternal" cycles like:
              * while (true)
                 * for (; ; ) -yes, you can leave params empty in for cycle




                Console.WriteLine($"Read second advice above how to get counter = {counter}");

             #endregion

             #region Third advice: make pause by cycle
                // pause or wasted cycle)
                int correctNumber = 0;
             while (Int32.TryParse(Console.ReadLine(), out correctNumber) == false)
             {
                 ;
             }
             // this is very good defense from fools, but be aware that it can hang your program up and fool would be you :(

             Console.WriteLine($"Read third advice above how to get correct number = {correctNumber}");

             #endregion

             #region Fourth advice: miss some calculations
             // mostly it is using in for or foreach cycles. You can jump to the next loop if some condition execude

             counter = 0;
             foreach (char letter in "Abracadabra")
             {
                 if (letter == 'a')
                 {
                     continue;
                 }
                 counter++;
             }
             Console.WriteLine($"Read fourth advice above how to get counter = {counter}");

             #endregion

             #region Fifth advice: be careful with nested cycles
             When we use break or continue in the nested cycle, it have an affect only in the nested cycle
             * Sometimes it should have an affect on the external cycle
             * In that case use boolean flag

            counter = 100;
             age = 0.0;
             bool death = false;
             int lenght = typeof(int).ToString().Length;
             while (true)
             {
                 counter--;
                 for (int i = 0; i < lenght; i++)
                 {
                     age += (1 + i) / 10.0;
                     if (age > counter)
                     {
                         death = true;
                     }
                 }
                 if (death)
                 {
                     break;  // system add you a prompt what cycle will be effected
                 }
             }

             Console.WriteLine($"Read fifth advice above how to get counter = {counter}");

             #endregion

             #endregion

             #region Recursive function

             // It means that any result we get can be used after in the calculation

             age = 10;
             age = age + 15; // instead age = 10 + 15;

             Often it can be used in cycles and big formulas
              *because cycle have time difficult as O(n).If we will do calculation for each member it would be as O(n1) + O(n2) + ...
              *or worse if we use nested cycles: O(n ^ 2) and more

             // For example: find sum of function: n*x + Sqrt(n)^x + x^ln(n)
             int n = 0;
             int x = 0;
             while (n <= 0 || x <= 0)
             {
                 Console.WriteLine("Введите n");
                 Int32.TryParse(Console.ReadLine(), out n);
                 Console.WriteLine("Введите x");
                 Int32.TryParse(Console.ReadLine(), out x);
             }
             double sum = 0.0;
             for (int i = 0; i < n; i++)
             {
                 sum += i * x + Math.Sqrt(i) + Math.Pow(x, Math.Log(n));
             }
             Console.WriteLine($"Сумма {sum} функции n*x + Sqrt(n)^x + x^ln(n) до {n}-ого члена");
             // Time complexity of this algorithm is O(n)


             // Attention! Do not do so!
             sum = 0.0;
             double firstMember = 0.0;
             double secondMember = 0.0;
             double thirdMember = 0.0;
             for (int i = 0; i < n; i++)
             {
                 firstMember += i * x;
             }
             for (int i = 0; i < n; i++)
             {
                 secondMember += Math.Sqrt(i);
             }
             for (int i = 0; i < n; i++)
             {
                 thirdMember += Math.Pow(x, Math.Log(n));
             }
             sum = firstMember + secondMember + thirdMember;
             // Time complexity of this algorithm is 3 * O(n)

             // Time complexity of this algorithm yet O(n). Do you understand why?
             for (int i = 0; i < n; i++)
             {
                 firstMember += i * x;
                 secondMember += Math.Sqrt(i);
                 thirdMember += Math.Pow(x, Math.Log(n));
                 sum += firstMember + secondMember + thirdMember;
             }

             // It is very important for nested cycles
             // Look at 1.12 example in the book 2100
             // If we would use straight (monkey) coding it would be awful as for us so for computer
             // Newer do so!!!! 3 level of cycle very bad practice!
             double previousSum;
             double e;
             int memberNumber = 0, factorial = 0;
             for (double i = 0.2; i <= 1; i += 0.2)
             {
                 sum = 1.0;
                 e = 1.0;
                 memberNumber = 1;
                 do
                 {
                     previousSum = sum;
                     factorial = 1;
                     for (int j = 1; j <= memberNumber; j++) // Such factorial calculation very difficult for PC and number can be very big (more than 2^32)
                     {
                         factorial *= (2 * j);
                     }
                     sum += Math.Pow(-1, memberNumber - 1) * ((2 * memberNumber - 1) * Math.Pow(i, 2 * memberNumber) / factorial);
                     e = sum - previousSum;
                     memberNumber++;
                 } while (Math.Abs(e) >= 0.0001);
                 Console.WriteLine($"Прирост суммы {sum:f4} стал очень мал при {memberNumber} для x = {i}"); // Formatting :f4 - 4 digit after ,
             }
             Console.WriteLine();

             // So what we have to do? Find dependence and use it.
             // For this example:
             double c;
             double a;

             for (double i = 0.2; i <= 1; i += 0.2)
             {
                 a = 0;
                 c = -1;
                 sum = 1;
                 double j = 1;
                 do
                 {
                     c = -c * i * i / ((2 * j - 1) * (2 * j)); // Value of new number
                     a = c * (2 * j - 1); // Multiplied on coefficient
                     sum += a;
                     j++;
                 } while (Math.Abs(a) >= 0.0001);
                 Console.WriteLine($"Прирост суммы {sum:f4} стал очень мал при {j} для x = {i}");
             }
             // We have less nested cycles and program works faster (for large n) but a little bit less correct on the rounding

             #endregion*/
            static void task_1_4()
            {
                double result = 0;
                double.TryParse(Console.ReadLine(), out double x1);
                for (int i = 0; i <= 8; i++)
                {
                    int j = i + 1;
                    result = result + Math.Cos(j * x1) / Math.Pow(x1, i);

                }
                Console.WriteLine(result);
            }
            static void task_1_9()
            {
                double result = 0;
                for (int i = 1; i <= 6; i++)
                {

                    int fac = 1 * i;
                    result = result + Math.Pow(-1, i) * Math.Pow(5, i) / fac;

                }
                Console.WriteLine(result);
            }
            static void task_1_15()
            {
                double a1 = 1;
                double a2 = 2;
                double b1 = 1;
                double b2 = 1;
                double n = 0;
                for (int i = 3; i <= 5; i++)
                {
                    n = (a1 + a2) / (b1 + b2);
                    double a_sum = a1 + a2;
                    double b_sum = b1 + b2;                   
                    a1 = a2;
                    a2 = a_sum;
                    b1 = b2;
                    b2 = b_sum;                    

                }
                Console.WriteLine(n);
            }
            static void task_1_16()
            {
                int n = 64;
                int a_1 = 1;
                double s = (a_1 * (Math.Pow(2, n) - 1));
                double mass = s / 15;
                Console.WriteLine("weight:");
                Console.WriteLine(mass);
                // with 100% accuracy
            }
            static void task_1_18()
            {
                int quality = 10;
                for (int period = 3; period <= 24; period += 3)
                {
                    quality += quality;
                    Console.WriteLine($"after {period}:");
                    Console.WriteLine(quality);
                }
            }
            static void task_2_2()
            {
                int p = 1;
                int mul = 1;
                while (p < 30000)
                {
                    mul += 3;
                    p *= mul;
                }
                Console.WriteLine(mul - 3);
            }
            static void task_2_4()
            {
                Console.WriteLine("enter x, use comma:");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    if (x < 1 & x > -1)
                    {
                        double n = 2;
                        double s = 1;
                        while (Math.Pow(x, n) > 0.0001)
                        {
                            s += Math.Pow(x, n);
                            n *= 2;
                        }
                        Console.WriteLine(s);

                    }
                    else
                    {
                        Console.WriteLine("input is wrong");
                    }
                }
                else
                {
                    Console.WriteLine("input is wrong");
                }

            }
            static void task_2_7_8()
            {
                double dist = 10;
                double k = 0.1;
                #region a
                double s = 0;
                for (int day = 1; day <= 7; day++)
                {
                    s += dist;
                    dist += k * dist;
                }
                Console.WriteLine(s);
                #endregion
                #region b
                s = 0;
                dist = 10;
                int days = 0;
                while (s < 100)
                {
                    days += 1;
                    s += dist;
                    dist += k * dist;
                }
                Console.WriteLine(days);
                #endregion
                #region B
                dist = 10;
                days = 1;
                while (dist < 20)
                {
                    days += 1;
                    dist *= 1.1;
                }
                Console.WriteLine(days);
                #endregion

            }
            static void task_3_1()
            {
                double i = 0;
                double s = 1;
                double n = 1; //first in sequence
                double a = 0.1;
                double b = 1;
                double h = 0.1;
                for (double x = a; x <= b + 0.0001; x = x + h)
                {

                    do
                    {
                        i++;
                        n = n * Math.Pow(x, 2) / (-4 * Math.Pow(i, 2) + 2 * i);
                        s = s + n;
                    }
                    while (Math.Abs(n) >= 0.0001);
                    Console.WriteLine($"s:{s:f10}\t\tcos={Math.Cos(x)}\tx:{x}");
                    i = 0;
                    n = 1;
                    s = 1;
                }
            }
            static void task_3_8()
            {
                double i = 0;
                double s = 1;
                double n = 1; //first in sequence
                double a = 0.1;
                double b = 1;
                double h = 0.05;
                for (double x = a; x <= b + 0.0001; x = x + h)
                {

                    do
                    {
                        i++;
                        n = n * 2 * x / i;
                        s = s + n;
                    }
                    while (Math.Abs(n) >= 0.0001);
                    Console.WriteLine($"s:{s:f10}\t\tfunc={Math.Pow(Math.E, 2 * x)}\tx:{x}");
                    i = 0;
                    n = 1;
                    s = 1;
                }

             
            }           
        }
    }
}

