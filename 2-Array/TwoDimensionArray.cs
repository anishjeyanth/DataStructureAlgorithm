using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class TwoDimensionArray
    {
        int[,] twoDimension;
        public TwoDimensionArray(int row, int column)
        {
            twoDimension = new int[row,column];

            for(int r = 0;r < row; r++)
            {
                for(int c = 0; c < column; c++)
                {
                    twoDimension[r, c] = r * c;
                }
            }

            //int[,,] threeArray = new int[2, 3, 4]{
            //    { { 1, 2, 3, 4}, {4, 5, 6, 7}, { 7, 8, 9, 10} },
            //    { { 7, 8, 9, 10}, {10, 11, 12, 13}, { 13, 14, 15, 16} }
            //};

            //threeArray[0, 1, 2] = 4; 
        }

        public void Display()
        {
            for (int r = 0; r < twoDimension.GetLength(0); r++)
            {
                Console.WriteLine("--");
                for (int c = 0; c < twoDimension.GetLength(1); c++)
                {
                    Console.WriteLine(twoDimension[r, c]);
                }
            }
        }

    }
}
