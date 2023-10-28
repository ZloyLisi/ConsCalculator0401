using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsCalculMDK0401
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
            Console.ReadKey();
        }
        static void Operaions(double num1, double num2, string operation)
        {
            double rez = 0;
            try
            {
                switch (operation)
                {
                    case "+":
                        rez = num1 + num2;
                        break;
                    case "-":
                        rez = num1 - num2;
                        break;
                    case "*":
                        rez = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0) throw new Exception("Деление на 0.");
                        rez = num1 / num2;
                        break;
                    default:
                        throw new Exception("Выбран неверный знак операции.");
                }
                Console.WriteLine($"Результат:\n{rez}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
        static void Calculate()
        {
            try
            {
                Console.WriteLine("Введите 1-ое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите знак операции:");
                string operation = Console.ReadLine().ToString();
                Console.WriteLine("Введите 2-ое число:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Operaions(num1, num2, operation);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Calculate();

        }
    }
}