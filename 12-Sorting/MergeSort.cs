﻿using DSA.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class MergeSort
    {
        public static int[] Merge(int[] Arr1, int[] Arr2)
        {
            Console.WriteLine("/////////");
            int[] combined = new int[Arr1.Length + Arr2.Length];
            int index = 0;
            int i = 0;
            int j = 0;
             
            while(i < Arr1.Length && j < Arr2.Length)
            {
                if(Arr1[i] < Arr2[j])
                {
                    combined[index] = Arr1[i];
                    index++;
                    i++;
                }
                else
                {
                    combined[index] = Arr2[j];
                    index++; 
                    j++;
                }
            }

            while(i < Arr1.Length)
            {
                combined[index] = Arr1[i];
                index++;
                i++;
            }

            while (j < Arr2.Length)
            {
                combined[index] = Arr2[j];
                index++;
                j++;
            }

            return combined;
        }

        public static int[] Sort(int[] Arr)
        {
            if (Arr.Length == 1)
                return Arr;

            int midIndex = Arr.Length / 2;
            Console.WriteLine("--A--" + JsonSerializer.Serialize(Arr) + " % " + JsonSerializer.Serialize(Arr[..midIndex]));
            int[] left = Sort(Arr[..midIndex]);
            Console.WriteLine("--B--" + JsonSerializer.Serialize(left) + " % " + JsonSerializer.Serialize(Arr[..midIndex]));
            Console.WriteLine();
            Console.WriteLine("$$$$$$$$$$$");
            Console.WriteLine();
            Console.WriteLine("--C--" + JsonSerializer.Serialize(Arr) + " % " + JsonSerializer.Serialize(Arr[midIndex..]));
            int[] right = Sort(Arr[midIndex..]);
            Console.WriteLine("--D--" + JsonSerializer.Serialize(right) + " % " + JsonSerializer.Serialize(Arr[midIndex..]));

            return Merge(left, right);
        }
    }
}
