//4-Üç Sayının En Büyüğünü Bulma (if-else)

namespace Acunmedya_Homework
{
    class Question4
    {
        public static void Main4()
        {
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number : ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double[] numbers = { number1, number2, number3 };

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = 0; j < numbers.Length - 1-i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        double temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The largest number = " + numbers[2]);
        }
    }
}
