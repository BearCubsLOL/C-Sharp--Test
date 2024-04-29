string[] board = {  "   a     b     c  ",
                    "      |     |     ",
                    "1  -  |  -  |  -  ",
                    " _____|_____|_____",
                    "      |     |     ",
                    "2  -  |  -  |  -  ",
                    " _____|_____|_____",
                    "      |     |     ",
                    "3  -  |  -  |  -  ",
                    "      |     |     "};
void Main()
    {
        PrintBoard();
        Choice();
    }
void PlaceX(int x, int y)
    {
        string mid = board[x];

                mid = mid.Remove(y,1).Insert(y, "x");

                board[x] = mid;

                PrintBoard();
    }
void PrintBoard() 
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine("\n\n\n\n");
                            
        foreach (string line in board)
            {
                Console.WriteLine(line);
            }

        Console.ResetColor();
    }

void Choice()
    {
        Console.WriteLine("\n\nWhere do you want to play?");
        string userChoice = Console.ReadLine();

        if (userChoice.ToLower() == "a1" || userChoice.ToLower() == "1a")
            {
                PlaceX(2, 3);
            }
        else if (userChoice == "a2" || userChoice == "2a")
            {
                PlaceX(2, 9);
            }
        else if (userChoice == "a3" || userChoice == "3a")
            {
                PlaceX(2, 15);
            }
        else if (userChoice == "b1" || userChoice == "1b")
            {
                PlaceX(5, 3);
            }
        else if (userChoice == "b2" || userChoice == "2b")
            {
                PlaceX(5, 9);
            }
        else if (userChoice == "b3" || userChoice == "3b")
            {
                PlaceX(5, 15);
            }
        else if (userChoice == "c1" || userChoice == "1c")
            {
                PlaceX(8, 3);
            }
        else if (userChoice == "c2" || userChoice == "2c")
            {
                PlaceX(8, 9);
            }
        else if (userChoice == "c3" || userChoice == "3c")
            {
                PlaceX(8, 15);
            }
        else
            {
                Console.WriteLine("\n\n\n\nInvalid Response");
                Main();
            }
    }

Main();