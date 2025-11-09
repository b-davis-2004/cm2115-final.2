namespace final.v1;

public class Map
{
    private readonly Dictionary<(int x, int y), IArea> _areas = new();

    public void AddArea(int x, int y, IArea area)
    {
        _areas[(x, y)] = area;
    }

    public IArea? GetArea(int x, int y)
    {
        _areas.TryGetValue((x, y), out var area);
        return area;
    }

    public void DescribeLocation(Player player)
    {
        var currentArea = GetArea(player.X, player.Y);
        if (currentArea != null)
        {
            Console.WriteLine($"\nYou are in the {currentArea.Name}.");
            Console.WriteLine(currentArea.Description);
        }
        else
        {
            Console.WriteLine("\nYou are wandering in uncharted lands...");
        }
    }
}

