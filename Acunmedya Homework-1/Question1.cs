
namespace Acunmedya_Homework
{
    class Question1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("Positive");
            else if (number < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
    }
}
