using System;
using System.Collections.Generic;

namespace Amazon_Two_sum_Unique_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 1, 5 };
            UniquePair(arr, 6);
            Console.WriteLine("Hello World!");
        }

        static Dictionary<int,int> UniquePair(int[] arr, int Target)
        {
            int len = arr.Length;
            if (len == 0)
                return null;
            Dictionary<int, int> Dic = new Dictionary<int, int>();
            Array.Sort(arr);

            for (int i = 0; i < len; i++)
            {
                if(arr[i]<Target)
                    if(!Dic.ContainsKey(arr[i]) && !Dic.ContainsValue(arr[i]))
                    {
                        for (int j = i+1 ; j < len; j++)
                        {
                            if (arr[i] + arr[j] == Target)
                            {
                                Dic.Add(arr[i], arr[j]);
                                break;
                            }
                        }
                    }
            }
            return Dic;
        }
    }
}
