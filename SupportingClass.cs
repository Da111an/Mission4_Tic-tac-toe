using System;

namespace Mission4
{
    internal class SupportingClass
    {
        // This method checks the board to see if there is a winner.
        // It returns "X" or "O" if someone won, or "" if there is no winner yet.
        public string CheckWinner(string[] board)
        {
            // This is all of our possible winning combinations
            int[][] winLines = new int[][]
            {
                new int[] { 0, 1, 2 }, // Row 1
                new int[] { 3, 4, 5 }, // Row 2
                new int[] { 6, 7, 8 }, // Row 3
                new int[] { 0, 3, 6 }, // Column 1
                new int[] { 1, 4, 7 }, // Column 2
                new int[] { 2, 5, 8 }, // Column 3
                new int[] { 0, 4, 8 }, // Diagonal \
                new int[] { 2, 4, 6 }  // Diagonal /
            };

            // Loop through each possible winning line
            foreach (int[] line in winLines)
            {
                int a = line[0];
                int b = line[1];
                int c = line[2];

                // If all three spots match and are not empty, we found the winner
                if (board[a] == board[b] && board[b] == board[c] && board[a] != "")
                {
                    return board[a]; // returns "X" or "O"
                }
            }

            // If no winning line was found, return empty string (no winner)
            return "";
        }
    }
}