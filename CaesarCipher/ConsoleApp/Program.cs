using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 1 && args[0] == "-e")
            {
                Program.choose();

            }
            else if (args.Length == 1 && args[0] == "-d")
            {
                Program.Decrypt();
            }

        }
        public static void choose(){

            Random random = new Random();
            int keyGenerated = random.Next(26);
            Regex regex = new Regex("^[0-9]*$");
            SymmetricAlgorithm sym = new SymmetricAlgorithm();
                Console.WriteLine("Type a string to encrypt");

                string plainsdText = Console.ReadLine();
                Console.WriteLine("Press 1 to generate key automatically! \n Press 2 to type it yourself!");
                string strZgjedhja=Console.ReadLine();
                if (!regex.IsMatch(strZgjedhja))
                {
                    Console.WriteLine("Keni dhene formatin Gabim, Provoni perseri!");
                    choose();
                }else
                {   
                    int zgjedhja = Convert.ToInt32(strZgjedhja); 
                    if (zgjedhja == 1){
                    Console.WriteLine("Generated key was " + keyGenerated);
                        string cypherText = sym.Enkripto(plainsdText, keyGenerated);
                        Console.WriteLine("Cyphertext is: " + cypherText);
                        Console.ReadKey();
                    }else if(zgjedhja == 2){
                       Console.WriteLine("Shtyp Celesin");
                        string input = Console.ReadLine();
                    if (!regex.IsMatch(input))
                    {
                        Console.WriteLine("Celesi eshte dhene gabim");
                        choose();
                    }
                    else
                    {
                           int key = Convert.ToInt32(input);
                           string cypherText = sym.Enkripto(plainsdText, key);
                           Console.WriteLine(cypherText);
                           Console.ReadKey();
                    }
                    }
                    else {
               
                          Console.WriteLine("Keni shtypur numrin gabim");
                          choose();
                    }
                }


        }

        public static void Decrypt()
        {
            Random random = new Random();
            int keyGenerated = random.Next(26);
            Regex regex = new Regex("^[0-9]*$");
            SymmetricAlgorithm sym = new SymmetricAlgorithm();
            Console.WriteLine("Type a string to decrypt");

            string cypherText = Console.ReadLine();
            Console.WriteLine("Press 1 to generate key automatically! \nPress 2 to type it yourself!");
            string strZgjedhja = Console.ReadLine();
            if (!regex.IsMatch(strZgjedhja))
            {
                Console.WriteLine("Keni dhene formatin Gabim, Provoni perseri!");
                Decrypt();
            }
            else
            {
                int zgjedhja = Convert.ToInt32(strZgjedhja);
                if (zgjedhja == 1)
                {
                    Console.WriteLine("Generated key was " + keyGenerated);
                    string plainText = sym.Dekripto(cypherText, keyGenerated);
                    Console.WriteLine("Plaintext: " + plainText);
                    Console.ReadKey();
                }
                else if (zgjedhja == 2)
                {
                    Console.WriteLine("Shtyp Celesin");
                    string input = Console.ReadLine();
                    if (!regex.IsMatch(input))
                    {
                        Console.WriteLine("Celesi eshte dhene gabim");
                        Decrypt();
                    }
                    else
                    {
                        int key = Convert.ToInt32(input);
                        string plainText = sym.Dekripto(cypherText, key);
                        Console.WriteLine(plainText);
                        Console.ReadKey();
                    }
                }
                else
                {

                    Console.WriteLine("Keni shtypur numrin gabim");
                    Decrypt();
                }
            }


        }
    }
    
}
