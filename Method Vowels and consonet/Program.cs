using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Vowels_and_consonet
{
    class Program
    {
        static void vowcon(char []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>=65 && arr[i]<=90 ||arr[i]>=97 && arr[i]<=122)
                {
                    if (arr[i] == 65 || arr[i] == 69 || arr[i] == 73 || arr[i] == 79 || arr[i] == 85 ||
                   arr[i] == 97 || arr[i] == 101 || arr[i] == 105 || arr[i] == 111 || arr[i] == 117)
                    {
                        Console.WriteLine(" Character is a  Vowels :"+arr[i]);
                    }
                    else
                    {
                        Console.WriteLine(" Character is s Consonet: " + arr[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Spcial Character :" + arr[i]);
                }
                
            }

        }
        static void Main(string[] args)
        {
            char[] arr1 = new char[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the character :");
                arr1[i] = Convert.ToChar(Console.ReadLine());

            }
                vowcon(arr1);
            Console.ReadLine();
        }
    }
}
