using System;

namespace PasswordEncryption
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a password to encrypt");
            string password = Console.ReadLine();

            //this is not intended for use with real passwords
            Console.WriteLine($"Is {password} correct?");

            //string alphabet = "0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //char[] alphabetChars = alphabet.ToCharArray();

            char[] passwordSplit = password.ToCharArray();

            Console.WriteLine("Enter a shift key number - any number of digits");
            int key = Convert.ToInt32(Console.ReadLine());

            //testing
            //Console.WriteLine(password);
            //Console.WriteLine(key);
            //Console.WriteLine((char)67);
            string keyString = key.ToString();
            int keylength = keyString.Length;
            string newPassword = password;
            for (int i = 0; i < passwordSplit.Length; i++)
            {
                int ascii = (int)passwordSplit[i];
                //Console.WriteLine(keyString[i % keylength]);
                //Console.WriteLine(Convert.ToInt32(keyString[i % keylength]));
                int newAscii = ascii + Convert.ToInt32(keyString[i%keylength])-48;
                //Console.WriteLine($"{ascii} -> {newAscii}");
                //Console.WriteLine($"{(char)ascii} -> {(char)newAscii}");
                Console.Write((char)newAscii);
            }


        }
    }
}
