/* 5-Şifre Güçlülüğünü Kontrol Etme (if-else)
🎯 Amaç: Kullanıcının girdiği şifrenin güçlü olup olmadığını kontrol eden program yaz.
📌 Koşullar:

Şifre en az 8 karakter uzunluğunda olmalı.
Şifre içinde @, #, $, % gibi özel karakterler içermeli.
Şifre en az 1 büyük harf içermeli.
*/
namespace Acunmedya_Homework
{
    class Question5
    {
        public static void Main5()
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long. ");
            }
            else
            {
                bool upperCharacter = false;
                for(int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        upperCharacter = true;
                        break;
                    }
                }
                if (!upperCharacter)
                {
                    Console.WriteLine("Password must contain at least one Upper character.");
                }
                else if(!(password.Contains("@") || password.Contains("#") || password.Contains('$') || password.Contains('%')))
                {
                    Console.WriteLine("Password must contain at least one (@, #, $, %) these special character");
                }
                else
                {
                    Console.WriteLine("Password is powerful");
                }
            }
        }
    }
}
