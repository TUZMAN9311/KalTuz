namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Напишите первое число:");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Напишите действие *,/,+,-,%");
                string operation = Console.ReadLine();
                Console.WriteLine("Напишите второе число:");
                double two = Convert.ToDouble(Console.ReadLine());

                if (operation == "*")
                {
                    Console.Write("Ответ:");
                    Console.Write(one * two);
                }
                else if (operation == "+")
                {
                    Console.Write("Ответ:");
                    Console.Write(one + two);
                }
                else if (operation == "-")
                {
                    Console.Write("Ответ:");
                    Console.Write(one - two);
                }
                else if (operation == "/")
                {
                    if (two == 0)
                    {
                        Console.Write("Ответ:");
                        Console.Write("Делить на ноль нельзя!");
                    }
                    else
                    {
                        Console.Write("Ответ:");
                        Console.Write(one / two);
                    }
                }
                else if (operation == "%") 
                {
                    Console.Write("Ответ:");
                    Console.Write(one / 100 * two);
                }
                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}