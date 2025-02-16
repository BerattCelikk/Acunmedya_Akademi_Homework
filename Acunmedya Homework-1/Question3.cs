//3-Basit Hesap Makinesi (switch-case)

namespace Acunmedya_Homework
{
    class Question3
    {
        public static void Main3()
        {
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Choose an operation (+,-,*,/) : ");
            string operation = Console.ReadLine();

            Console.WriteLine("Result: ");
            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    if(number2 != 0)
                    {
                        Console.WriteLine(number1 / number2);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divided by 0");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
