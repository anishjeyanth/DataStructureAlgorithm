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
        string[,] twoDimension;
        public TwoDimensionArray(int row, int column)
        {
            twoDimension = new string[row,column];

            for(int r = 0;r < row; r++)
            {
                for(int c = 0; c < column; c++)
                {
                    twoDimension[r, c] = string.Join(r.ToString(), c.ToString());
                }
            }
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
