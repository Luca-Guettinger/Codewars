using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class TicTacToe_Checker
    {
        public int IsSolved(int[,] board)
        {
            foreach (int i in board)
            {
                if (i == 0) return -1;
            }
            int[] results = new int[7];
            results[0] = diagonal(board);
            results[1] = NextTo(XY.X, board, 0, 1);
            results[2] = NextTo(XY.X, board, 1, 1);
            results[3] = NextTo(XY.X, board, 2, 1);
            results[4] = NextTo(XY.Y, board, 1, 0);
            results[5] = NextTo(XY.Y, board, 1, 1);
            results[6] = NextTo(XY.Y, board, 1, 2);

            foreach (int i in results)
            {
                if (i != 0) return i;
            }
            return 0;
        }


        public static int NextTo(XY achse, int[,] board, int arrayPostition1, int arrayPostition2)
        {
            if (achse == XY.X)
            {
                if (board[arrayPostition1, arrayPostition2] == board[arrayPostition1, arrayPostition2 - 1] &&
                   board[arrayPostition1, arrayPostition2] == board[arrayPostition1, arrayPostition2 + 1])
                {
                    if (board[arrayPostition1, arrayPostition2] == 1) return 1;
                    else if (board[arrayPostition1, arrayPostition2] == 2) return 2;
                }
                else
                {
                    return 0;
                }
            }

            else if (achse == XY.Y)
            {
                if (board[arrayPostition1, arrayPostition2] == board[arrayPostition1 - 1, arrayPostition2] &&
                   board[arrayPostition1, arrayPostition2] == board[arrayPostition1 + 1, arrayPostition2])
                {
                    if (board[arrayPostition1, arrayPostition2] == 1) return 1;
                    else if (board[arrayPostition1, arrayPostition2] == 2) return 2;
                }
                else
                {
                    return 0;
                }
            }
            Console.WriteLine("Das sollte nicht passieren...");
            return -1;
        }
        public static int diagonal(int[,] board)
        {
            if (board[1, 1] == board[0, 0] && board[1, 1] == board[2, 2])
            {
                if (board[1, 1] == 1) return 1;
                else if (board[1, 1] == 2) return 2;
            }
            else if (board[1, 1] == board[0, 2] && board[1, 1] == board[2, 0])
            {
                if (board[1, 1] == 1) return 1;
                else if (board[1, 1] == 2) return 2;
            }
            return 0;
        }

        public enum XY
        {
            X, Y
        }
    }
}
