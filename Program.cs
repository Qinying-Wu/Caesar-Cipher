using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static string[] the_letters={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Input the word to be ciphered: ");
                string input = Console.ReadLine();
                if (input.Any(char.IsUpper))
                {
                    Console.WriteLine("Please ensure all inputs are in lower case only");
                }
                else
                {
                    Console.WriteLine("shift by: ");
                    int shift;
                    int.TryParse(Console.ReadLine(), out shift);
                    for (int i = 0; i < input.Length; i++)
                    {
                        input = input.Replace(input.Substring(i, 1), find_letter(0, 25, shift, input.Substring(i, 1)));

                    }
                    Console.WriteLine(input);
                }
            }
        }
        static string find_letter(int left, int right,int shift, string letter)
        {
            int mid = (left + right) / 2;
            if (letter.CompareTo(the_letters[mid]) ==-1&&mid-1>=left)
            {
                return find_letter(left, mid - 1,shift, letter);
            }
            else if (letter.CompareTo(the_letters[mid]) ==1&&mid+1<=right)
            {
                return find_letter(mid + 1, right, shift, letter);
            }
            else
            {
                if (mid + shift <= 25)
                {
                    return the_letters[mid + shift];
                }
                else
                {
                    return the_letters[mid-25 + shift];
                }
            }
        }
    }
}
