using System;
using System.Collections.Generic;
using System.Text;

namespace Mission4
{
    internal class SupportingClass
    {
        public void PrintBoard(string[] board)
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
    }
}
