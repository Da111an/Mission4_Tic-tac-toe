namespace Mission4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            SupportingClass sc = new SupportingClass();

            string currentPlayer = "X";
            string[] board = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Board initialized: ");


            do
            {
                // print the tic-tac-toe board with numbers in their respective places
                if (currentPlayer == "X")
                {
                    Console.WriteLine("Player 1 (X), please input your location choice.");
                    sc.PrintBoard(board);
                }
                else if (currentPlayer == "O")
                {
                    Console.WriteLine("Player 2 (O), please input your location choice.");
                    sc.PrintBoard(board);
                }
            } while (sc.CheckResult);

            



        }
    }
}
