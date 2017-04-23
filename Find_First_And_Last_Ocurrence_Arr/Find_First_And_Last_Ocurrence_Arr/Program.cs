using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// http://practice.geeksforgeeks.org/problems/find-first-and-last-occurrence-of-x/0
/// Find first and last occurrence of x
/// Given a sorted array with possibly duplicate elements, the task is to find indexes of first and last occurrences of an element x in the given array.

//Examples:

//Input : A[] = {1, 3, 5, 5, 5, 5 ,67, 123, 125}    
//        x = 5
//Output : First Occurrence = 2
//         Last Occurrence = 5

//Input : A[] = {1, 3, 5, 5, 5, 5 ,7, 123 ,125 }    
//        x = 7
//Output : First Occurrence = 6
//         Last Occurrence = 6

/// </summary>
namespace Find_First_And_Last_Ocurrence_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 5, 5, 5, 67, 123, 125 };
            int findVal = 5;
            int firstIndex = -1;
            int lastIndex = -1;
            for(int i=0;i<=arr.Length-1;i++)
            {
                if(arr[i]== findVal)
                {
                    firstIndex = i;
                    break;
                }
            }

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] == findVal)
                {
                    lastIndex = i;
                    
                }
            }

            Console.WriteLine("First Index " + firstIndex);

            Console.WriteLine("Last Index " + lastIndex);
            Console.ReadLine();
        }
    }
}
