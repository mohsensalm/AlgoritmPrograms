using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    

    class EightQueensSolver
    {

        private const int BoardSize = 4;
        private readonly int[] _queens = new int[BoardSize];

        //public EightQueensSolver()
        //{
        //    queens = new int[BoardSize];
        //}

        public void Solve()
        {
            PlaceQueen(0);
        }
        /// <summary>
        /// In this implementation, the EightQueensSolver class encapsulates the logic for solving the problem. The queens array is used to store the column position of each queen for each row. The Solve method initiates the solving process by calling PlaceQueen starting from the first row.
        /// 
        /// The PlaceQueen method uses a recursive approach to try different column positions for the current row. If a safe position is found, the queen is placed, and the method calls itself for the next row. If all rows are filled successfully, the PrintSolution method is called to print the solution.
        /// 
        /// The IsSafe method checks whether it is safe to place a queen at a given row and column position. It checks for conflicts with queens in previous rows, both diagonally and horizontally.
        /// 
        /// Finally, the PrintSolution method prints the board representation, using "Q" for queens and "." for empty spaces.
        /// 
        /// You can run the program, and it will print all possible solutions for the 8-queens problem. Each solution represents a valid arrangement of 8 queens on an 8x8 chessboard, where no two queens threaten each other.
        /// </summary>


        private void PrintSolution()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    if (_queens[row] == col)
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private void PlaceQueen(int row)
        {
            if (row == BoardSize)
            {
                PrintSolution();
                return;
            }

            for (int col = 0; col < BoardSize; col++)
            {
                if (IsSafe(row, col))
                {
                    _queens[row] = col;
                    PlaceQueen(row + 1);
                }
            }
        }

        private bool IsSafe(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (_queens[i] == col || _queens[i] - i == col - row || _queens[i] + i == col + row)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
