using System;

namespace T07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textField = Console.ReadLine();

            int bomb = 0;

            for (int i = 0; i < textField.Length; i++)
            {           
                if (bomb > 0 && textField[i] != '>')
                {
                    textField = textField.Remove(i, 1);
                    bomb--;
                    i--;
                }             
                else if (textField[i] == '>')
                {
                    bomb += int.Parse(textField[i + 1].ToString());
                }
            }
            Console.WriteLine(textField);
        }
    }
}