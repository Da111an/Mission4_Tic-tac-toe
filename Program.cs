namespace Mission4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            SupportingClass sc = new SupportingClass();

            string currentPlayer = "X";
            string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
            string choice = "";
            Console.WriteLine("Welcome to Tic-Tac-Toe!\n");
            
            Console.WriteLine("Board initialized: \n");
            
            int turns = 0;

            do
            {
                // print the tic-tac-toe board with numbers in their respective places
                sc.PrintBoard(board);
                if (currentPlayer == "X")
                {
                    Console.Write("Player 1 (X), please input your location choice: ");
                    choice = Console.ReadLine();
                    Console.WriteLine();
                }
                else if (currentPlayer == "O")
                {
                    Console.Write("Player 2 (O), please input your location choice: ");
                    choice = Console.ReadLine();
                    Console.WriteLine();

                }

                if (int.TryParse(choice, out int choiceInt) && choiceInt >= 1 && choiceInt <= 9)
                {
                    int index = choiceInt - 1; // Map 1-9 to 0-8

                    // VALIDATION: Check if the spot is already taken
                    if (board[index] != "X" && board[index] != "O")
                    {
                        // UPDATE: Change the array value to the current player
                        board[index] = currentPlayer;
                        turns++;

                        // SWITCH PLAYER: Only switch if the game isn't won yet
                        if (sc.CheckWinner(board) == "")
                        {
                            if (turns == 9)
                            {
                                Console.WriteLine("It's a draw!");
                                break;
                            }
                                currentPlayer = (currentPlayer == "X") ? "O" : "X";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that spot is already taken! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number between 1 and 9.");
                }
            } while (sc.CheckWinner(board) == "");

            sc.PrintBoard(board);
            string winner = sc.CheckWinner(board);
            if (winner != "") // If we didn't end in a draw
            {
                Console.WriteLine($"Congratulations! Player {winner} has won!");
            }





        }
    }
}
