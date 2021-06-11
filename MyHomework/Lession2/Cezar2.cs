﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Lession2
{
    public class Cezar2
    {
        public static void Run()
        {
            for (; ; )
            {
                // > "HI"
                //Console.WriteLine("\\\"Строка\\\"\0");
                // \"Строка\"

                Console.Write("Введите текст :");
                string text = Console.ReadLine();
                Console.WriteLine("Выберите число где 1-Шифрование и 2-Дешифрование");
                var oper = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ключ");
                int key = Convert.ToInt32(Console.ReadLine());
                
                if (oper == 1)
                {
                    Console.WriteLine(Encrypt(text, key));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(Decrypt(text, key));
                    Console.WriteLine();
                }
            }
        }

        public static string Decrypt(string text, int key) // Дешифровка
        {
            int startLowerChar = 'a';
            int endLowerChar = 'z';
            int startUpperChar = 'A';
            int endUpperChar = 'Z';

            char[] buffer = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                int symbol = text[i];
                if (symbol != ' ')
                {
                    // [a-z][A-Z][ ]
                    int endChar = endLowerChar, startChar = startLowerChar; 
                    if(char.IsUpper(text[i]))
                    {
                        endChar = endUpperChar;
                        startChar = startUpperChar;
                    }

                    symbol -= key;
                    if (symbol < startChar)
                    {
                        symbol = endChar + (symbol - startChar) + 1;
                    }
                }

                buffer[i] = (char)symbol;
            }
            return new string(buffer);
        }

        public static string Encrypt(string text, int key) // Шифрование
        {  
            // a = 10
            // z = 30
            // z + 1 = ?

            // x [28] + 5 = b ?
            // 
            // abcdef.....xyz[]
            // text = hello z
            int startLowerChar = 'a';
            int endLowerChar = 'z';
            int startUpperChar = 'A';
            int endUpperChar = 'Z';

            char[] buffer = new char[text.Length];
            
            for (int i = 0; i < text.Length; i++)
            {
                int symbol = text[i];
                if (symbol != ' ')
                    {
                        int endChar = endLowerChar, startChar = startLowerChar;
                    if (char.IsUpper(text[i]))
                    {
                        endChar = endUpperChar;
                        startChar = startUpperChar;
                    }

                    symbol += key;
                    if (symbol > endChar)
                    {
                        symbol = startChar + (symbol - endChar) - 1;
                    }
            }
                buffer[i] = (char)symbol;
            }
            return new string(buffer);
        }
        
    }
}
//       "Old metod Encrypt"
//if (text[i] == text.ToUpper()[i])
//{
//    symbol = symbol + key;
//
//    if (symbol > endUpperChar)
//    {
//        symbol = startUpperChar + (symbol - endUpperChar) - 1;
//    }
//}
//else
//{
//    symbol = symbol + key;
//    if (symbol > endLowerChar)
//    {
//        // a [10] x [28] z [30]   x + 5 = 33
//        // 10 + (33 - 30)
//        symbol = startLowerChar + (symbol - endLowerChar) - 1;
//    }
//}
//    buffer[i] = (char)symbol;
