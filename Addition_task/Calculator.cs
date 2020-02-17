using System;

namespace Addition_task
{
    static class Calculator
    {
        public static void CollectsMethod(this int variable1, int variable2)
        {
            AddUpTheNumbers(variable1, variable2);
            if (variable1 < variable2)
                SubstractNumbers(variable2, variable1);
            else
                SubstractNumbers(variable1, variable2);
            if (variable2 != 0)
            {
                DivideNumbers(variable1, variable2);
                DivideNumbersWithThRemainder(variable1, variable2);
            }
            else
            {
                Console.WriteLine("Деление на ноль запрещено!");
            }
        }

        static void AddUpTheNumbers(int firstOperand, int secondOperand)
        {
            Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
        }

        static void SubstractNumbers(int firstOperand, int secondOperand)
        {
            Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
        }

        static void DivideNumbers(int firstOperand, int secondOperand)
        {
            Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
        }

        static void DivideNumbersWithThRemainder(int firstOperand, int secondOperand)
        {
            Console.WriteLine($"{firstOperand} % {secondOperand} = {firstOperand / secondOperand}.{firstOperand % secondOperand}");
        }
    }
}
