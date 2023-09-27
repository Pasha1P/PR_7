using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "проверочная работа №7";

            uint e, n;
            int x;
            double sum = 0, sum1, b = 1, c = 1;


            try
            {


                Console.WriteLine("введите некоторое целое число e для нахождения суммы чисел ряда");
                e = Convert.ToUInt32(Console.ReadLine());
                for (int j = 1; j > 0; j += 0)
                {
                    Console.WriteLine("введите число n для нахождения члена ряда");
                    n = Convert.ToUInt32(Console.ReadLine());

                    if (n >= e)
                    {
                        if (n == 0)
                        {
                            sum = 1 / n;
                        }
                        else
                        {
                            for (int i = 1; i <= n; i++)
                            {
                                b *= i;
                            }
                            for (int i = 1; i <= (2 * n); i++)
                            {
                                c *= i;
                            }
                            sum1 = +Math.Pow(3, n) * b / c;
                            b = 1;
                            c = 1;
                            sum = sum1 + sum;
                        }
                    }
                    Console.WriteLine("сумма " + sum);
                    Console.WriteLine("чтобы выйти нажмите 0 что бы остаться нажмите другую цифру");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 0)
                    {
                        break;
                    }
                }
            }            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка. Исключение деления на ноль.");
            }
            catch (ArgumentOutOfRangeException q)
            {
                Console.WriteLine("Исключение аргумента вне диапазона. Ошибка: " + q.Message);
            }
            catch (OperationCanceledException d)
            {
                Console.WriteLine("Исключение отмены операции. Ошибка: " + d.Message);
            }
            catch (FormatException a)
            {
                Console.WriteLine("Исключение формата. Ошибка: " + a.Message);                
            }
            catch (Exception w)
            {
                Console.WriteLine("Что то пошло не так. Ошибка: " + w.Message);
            }

            Console.ReadKey();

        }
    }
}
