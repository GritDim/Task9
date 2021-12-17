using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            Console.WriteLine("Введите числа A и B");

            int a = 0;
            int b = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка формата данных");
                Console.ReadKey();
                return;
            }
            
            

            Console.WriteLine("Введите код операции: 1 - сложение, 2 - вычитание, 3 - произведение, 4 - частное");

            int calcType = Convert.ToInt32(Console.ReadLine());

            if ((calcType != 1) && (calcType != 2) && (calcType != 3) && (calcType != 4))
            {
                Console.WriteLine("Ошибка ввода кода операции вычисления");
            }
            else
            {
                if (calcType==1)
                {
                    Console.WriteLine("Операция сложения А + B = {0}", (a+b));
                }

                if (calcType == 2)
                {
                    Console.WriteLine("Операция вычитания А - B = {0}", (a-b));
                }


                if (calcType == 3)
                {
                    Console.WriteLine("Операция умножения А * B = {0}", (a*b));
                }

                if (calcType == 4)
                {
                    try
                    {
                        int d = a / b;  // double деляться на 0 без возникновения исключения, данная строка как триггер возникновения исключения
                        Console.WriteLine("Операция деления А / B = {0}", ((double)a/b));
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка деление на ноль");
                    }                
                }
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadKey();
        }
    }
}
