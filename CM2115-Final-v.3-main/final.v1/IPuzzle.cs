namespace final.v1;

public interface IPuzzle
{
    string Name { get; }
    string Description { get; }
    
    bool Solve(Player player);
    bool IsSolved { get; }
}

 //tells you what the puzzle is
 //represents a puzzle (an object)
 //will be used by PuzzleConflicts
