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
        ///
        ///
        /// .................................................................
        /// Define the chessboard size (8x8 in this case).
        /// Create an array to store the column position of each queen for each row.
        /// Start with the first row (row 0).
        /// For each column in the current row:
        /// Check if it is safe to place a queen at the current position.
        /// If it is safe, store the column position in the array and move to the next row.
        /// If it is not safe, try the next column.
        /// If all columns have been tried and none are safe, backtrack to the previous row.
        /// If the current row is the last row (row 7 in the case of an 8x8 board), a solution has been found.
        /// Print the solution or store it in a collection of solutions.
        /// Backtrack to the previous row to find other solutions (if any).
        /// Repeat steps 4-5 until all solutions have been found.
        ///
        ///
        /// 
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
