using System;

namespace Messages2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= count; i++)
            {
                string number = Console.ReadLine();
                int mainDigit = int.Parse(number[0].ToString());

                if (mainDigit == 2)
                {
                    if (number.Length == 1)
                    {
                        word += (char)97;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)98;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)99;
                    }
                }
                else if (mainDigit == 3)
                {
                    if (number.Length == 1)
                    {
                        word += (char)100;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)101;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)102;
                    }
                }
                else if (mainDigit == 4)
                {
                    if (number.Length == 1)
                    {
                        word += (char)103;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)104;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)105;
                    }
                }
                else if (mainDigit == 5)
                {
                    if (number.Length == 1)
                    {
                        word += (char)106;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)107;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)108;
                    }
                }
                else if (mainDigit == 6)
                {
                    if (number.Length == 1)
                    {
                        word += (char)109;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)110;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)111;
                    }
                }
                else if (mainDigit == 7)
                {
                    if (number.Length == 1)
                    {
                        word += (char)112;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)113;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)114;
                    }
                    else if (number.Length == 4)
                    {
                        word += (char)115;
                    }
                }
                else if (mainDigit == 8)
                {
                    if (number.Length == 1)
                    {
                        word += (char)116;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)117;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)118;
                    }
                }
                else if (mainDigit == 9)
                {
                    if (number.Length == 1)
                    {
                        word += (char)119;
                    }
                    else if (number.Length == 2)
                    {
                        word += (char)120;
                    }
                    else if (number.Length == 3)
                    {
                        word += (char)121;
                    }
                    else if (number.Length == 4)
                    {
                        word += (char)122;
                    }
                }
                else if (mainDigit == 0)
                {
                    word += " ";
                }
            }
            Console.WriteLine(word);
        }
    }
}
