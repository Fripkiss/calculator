namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Возведение в квадрат");
            Console.WriteLine("7. Стерание/удаление");
            Console.WriteLine("8. Равно");

            string choice = Console.ReadLine();

            if (choice == "7")
            {
                Console.WriteLine("Введите число:");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат: " + Clear(number));
            }
            else if (choice == "8")
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Результат: " + Equals(num1, num2));
            }
            else
            {
                Console.WriteLine("Введите первое число:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Результат: " + Add(num1, num2));
                        break;
                    case "2":
                        Console.WriteLine("Результат: " + Subtract(num1, num2));
                        break;
                    case "3":
                        Console.WriteLine("Результат: " + Multiply(num1, num2));
                        break;
                    case "4":
                        Console.WriteLine("Результат: " + Divide(num1, num2));
                        break;
                    case "5":
                        Console.WriteLine("Результат: " + Power(num1, num2));
                        break;
                    case "6":
                        Console.WriteLine("Результат: " + Square(num1));
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор операции.");
                        break;
                }
            }
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                return double.NaN; 
            }
            return x / y;
        }

        static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        static double Square(double x)
        {
            return x * x;
        }

        static double Clear(double x)
        {
            return 0;
        }

        static bool Equals(double x, double y)
        {
            return x == y;
        }
    }
}
            