using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string morze;
            string out_str;
            

            //morze = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
            //morze = "1 2 3   4 . . .   .   .";
            
            Console.WriteLine("\n Введите код Морзе: \n");
            morze = Console.ReadLine();

            Console.WriteLine("\n Декодированная строка: \n");
            out_str = Decoding.Morze2English(morze);

            Console.WriteLine(out_str);

            Console.WriteLine("\n\n Press any key to exit...");
            Console.ReadKey(true);
        }
    }
        public class Decoding
        {
            public static string Morze2English(string morze)
            {
                string out_str = "";
                string[] str = morze.Replace("   ", "  ").Split(' ');
                for (int i = 0; i < str.Length; i++)
                {
                    // Console.WriteLine("("+str[i]+")");
                    out_str += MorseCodeDictionary.TryGetValue(str[i], out string letter)
                    ? letter
                    : "*";
                }
                return out_str;
            }

            public static Dictionary<string, string> MorseCodeDictionary = new Dictionary<string, string>() {
            { ".-", "A"},
            { "-...", "B"},
            { "-.-.", "C"},
            { "-..", "D"},
            { ".", "E"},
            { "..-.", "F"},
            { "--.", "G"},
            { "....", "H"},
            { "..", "I"},
            { ".---", "J"},
            { "-.-", "K"},
            { ".-..", "L"},
            { "--", "M"},
            { "-.", "N"},
            { "---", "O"},
            { ".--.", "P"},
            { "--.-", "Q"},
            { ".-.", "R"},
            { "...", "S"},
            { "-", "T"},
            { "..-", "U"},
            { "...-", "V"},
            { ".--", "W"},
            { "-..-", "X"},
            { "-.--", "Y"},
            { "--..", "Z"},
            { "", " "},
            };
        }
    }