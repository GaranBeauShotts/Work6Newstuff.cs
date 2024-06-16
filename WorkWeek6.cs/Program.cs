using System;
using  WorkWeek6.cs;

class Program
{
    static void Main()
    {
        // Create a SoccerPlayer object
        Player.SoccerPlayer player = new Player.SoccerPlayer("John Doe", 10, 15, 5);

        // Display player information
        Console.WriteLine("Player Name: " + player.Name);
        Console.WriteLine("Jersey Number: " + player.JerseyNumber);
        Console.WriteLine("Goals Scored: " + player.GoalsScored);
        Console.WriteLine("Assists: " + player.Assists);

        // Wait for user input before closing console window (optional)
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
