/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
Написать программу, которая выводит на экран основные арифметические операции. 
 */
using System;

namespace Addition_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число = ");
            int operand1 = Int32.Parse(Console.ReadLine());
            Console.Write($"Второе число = ");
            int operand2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            operand1.CollectsMethod(operand2);

            Console.ReadKey();
        }
    }
}
