using final.v1;

Player player = new Player();
Map world = new Map();

// Define map layout
// Uses Concreate Area and Conflict implementations
//Might be better to define coordinates outside of main program
world.AddArea(0, 0, new Area1{ Conflict = new CombatConflict(new Enemy1()) });
world.AddArea(1, 0, new Area2{ Conflict = new CombatConflict(new Enemy2()) });    // East +1

Console.WriteLine("Welcome, adventurer!");
Console.WriteLine("Use W/A/S/D to move North/West/South/East. Type 'quit' to exit.\n");

while (player.Health > 0)
{
    world.DescribeLocation(player);

    var currentArea = world.GetArea(player.X, player.Y);
    if (currentArea != null)
    {
        currentArea.Enter(player);
    }

    if (player.Health <= 0)
    {
        Console.WriteLine("You have fallen in battle. Game Over.");
        break;
    }

    Console.Write("\nWhere do you want to go (W/A/S/D)? ");
    string? input = Console.ReadLine()?.Trim().ToLower();

    if (input == "quit") break;

    switch (input)
    {
        case "w": player.Y += 1; break;
        case "s": player.Y -= 1; break;
        case "a": player.X -= 1; break;
        case "d": player.X += 1; break;
        default:
            Console.WriteLine("Invalid command. Use W/A/S/D or 'quit'.");
            break;
    }

    Console.WriteLine($"Your current health: {player.Health}");
}

Console.WriteLine("\nThanks for playing!");
// Main game loop handling player movement and area interactions
// Initializes player and world map