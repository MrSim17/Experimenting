using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void MultidimensionalArray()
        {
            // https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx
            // Two Dimensions - requires fixed lengths
            int[,] twoDim = new int[2,2];

            twoDim[0, 0] = 0;
            twoDim[0,1] = 1;
            twoDim[1, 0] = 2;

            twoDim = new int[,] { {0,1}, {2,3} }; // can omit the size if it is decidable during init

            // more than just 3 dimensions
            int[,,,] fourDim = new int[2, 2, 2, 2];
            int[,,,,] fiveDim = new int[2, 2, 2, 2, 2];
            int[,,,,] sixDim = new int[2, 2, 2, 2, 2];
            int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] oneHundredDim = new int[2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2];

            // Jagged Arrays - does not require fixed lengths in one dimension
            // https://msdn.microsoft.com/en-us/library/2s05feca.aspx
            int[][] jagged = new int[2][]; // second array requires no size
            jagged = new int[1][] { new int[1] };

        }

        public void JaggedArray()
        {

        }
    }
}
