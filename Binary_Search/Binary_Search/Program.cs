using System;
using System.Collections.Generic;

namespace Binary_Search
{
    class Program
    {
        public static string Binary_Search(List<int>arr,int searchValue)
        {
            int low = 0;
            int high = arr.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if(searchValue == arr[mid])
                {
                    return $"Search Value: {searchValue}\'s Position: {mid+1}.";
                }
                else if(searchValue > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return $"Search Value: {searchValue} not found.";
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() {20,30,1,5,9,3,22};
            arr.Sort();
            Console.Write("Enter your search value : ");
            int searchValue = Convert.ToInt32(Console.ReadLine());
            string result = Binary_Search(arr,searchValue);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
