using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Напиши что нибудь ");
            string word = Console.ReadLine();
            Console.WriteLine(ReversStr(word));
            Console.ReadLine();
        }
         char[] ReversStr(string str)
        {
            char[] array = new char[str.Length];
            int j = str.Length - 1;
            for (int i = 0; i < str.Length / 2; i++)
            {
                array[i] = str[j];
                j--;
            }
            j = 0;
            for (int i = str.Length - 1; i >= str.Length / 2; i--)
            {
                array[i] = str[j];
                j++;
            }
            return array;
        }
    }
}

