using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Lession1
{
    public class VosvedenieVStepen
    {
        public static double Getpow(double n, double p)
        {
            return Math.Exp(Math.Log(n) * p);
        }

        public void Run()
        {
            // Читает введёное любое (включая с точкой) число пользователя.
            // Если он ввёл НЕ число то пользователь должен быть уведомлен
            // получив сообщение "Повторите ввод"
            // Цель - пользователь вводит 2-а числа, а программа
            // Возводит в степень число вызывая функцию GetPow
            // В которой нельзя использовать математическую функцию возведения
            // в степень (Нельзя использовать Math.Pow) необходимо самому реализовать
            // метод возведения в степень
            for (; ; )
            {
                Console.WriteLine("Введите число: ");
                string number = Console.ReadLine();
                double n;
                if (Double.TryParse(number, out n))
                {
                    Console.WriteLine();
                    Console.WriteLine("Введите степень: ");
                    string power = Console.ReadLine();
                    double p;
                    if (Double.TryParse(power, out p))
                    {
                        double result = Getpow(n, p);
                        Console.WriteLine();
                        Console.WriteLine($"Число {number} в степени {power} равно {result}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введенное значение не является числом");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Введенное значение не является числом");
                    Console.WriteLine();
                }
            }
        }
    }
}
