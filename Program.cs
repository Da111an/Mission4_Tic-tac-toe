namespace Mission4
{
    internal class Program
    {
        SupportingClass sp = new SupportingClass();
        static void Main(string[] args)
        {
            double playerTurn = 1;
            
            
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Board initialized: ");


            string[] board = ["1","2","3","4","5","6","7","8","9"];

            // print the tic-tac-toe board with numbers in their respective places
            if (playerTurn == 1)
            {
                Console.WriteLine("Player 1, please choose the number that corresponds to the locaiton you want to select.");

            }



        }
    }
}
