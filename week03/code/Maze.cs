using System.Collections.Generic;

/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private Dictionary<(int, int), bool[]> _mazeMap;
    private (int, int) currentPos;


    public Maze(Dictionary<(int, int), bool[]> mazeMap)
    {
        _mazeMap = mazeMap;

        currentPos = (1, 1);
    }
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft()
    {
        int Xpos = currentPos.Item1;
        int Ypos = currentPos.Item2 - 1;

        if (IsValid(Xpos, Ypos, 0))
        {
            currentPos = (Xpos, Ypos);
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight()
    {
        int Xpos = currentPos.Item1;
        int Ypos = currentPos.Item2 + 1;

        if (IsValid(Xpos, Ypos, 1))
        {
            currentPos = (Xpos, Ypos);
        }
    }


    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp()
    {
        int Xpos = currentPos.Item1 - 1;
        int Ypos = currentPos.Item2;

        if (IsValid(Xpos, Ypos, 2))
        {
            currentPos = (Xpos, Ypos);
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown()
    {
        int Xpos = currentPos.Item1 + 1;
        int Ypos = currentPos.Item2;

        if (IsValid(Xpos, Ypos, 3))
        {
            currentPos = (Xpos, Ypos);
        }
    }

    private bool IsValid(int x, int y, int direction)
    {
        if (!_mazeMap.ContainsKey((x, y)))
            return false;
        return _mazeMap[(x, y)][direction];
    }

    public (int, int) GetCurrentPos()
    {
        return currentPos;
    }


    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={currentPos.Item1}, y={currentPos.Item2})");
    }
}