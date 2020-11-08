using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] rotations = Console.ReadLine().Split();
        foreach (string rotation in rotations)
        {
            Console.Error.WriteLine($"Rotation: {rotation}");
        }

        string face1 = Console.ReadLine();
        string face2 = Console.ReadLine();
        Console.Error.WriteLine($"Search for 1: {face1}");
        Console.Error.WriteLine($"Search for 2: {face2}");

        Cube myCube = new Cube();
        foreach (string rotation in rotations)
        {
            myCube.Move(rotation);
            Console.Error.WriteLine($"Face1 is now {myCube.GetPositionOfFace(face1)}");
            Console.Error.WriteLine($"Face2 is now {myCube.GetPositionOfFace(face2)}");
        }
        Console.WriteLine(myCube.GetPositionOfFace(face1));
        Console.WriteLine(myCube.GetPositionOfFace(face2));
    }

}
class Cube
{
    public string Top { get; private set; }
    public string Down { get; private set; }
    public string Left { get; private set; }
    public string Right { get; private set; }
    public string Front { get; private set; }
    public string Back { get; private set; }
    
    public Cube()
    {
        Top = "U";
        Down = "D";
        Left = "L";
        Right = "R";
        Front = "F";
        Back = "B";
    }
    public void Move(string rotation)
    {
        string temp;
        switch (rotation)
        {
            case "x":
                Console.Error.WriteLine($"Moving x");
                temp = Top;
                Top = Front;
                Front = Down;
                Down = Back;
                Back = temp;
                break;

            case "x'":
                Console.Error.WriteLine($"Moving counter x");
                temp = Top;
                Top = Back;
                Back = Down;
                Down = Front;
                Front = temp;
                break;

            case "y":
                Console.Error.WriteLine($"Moving y");
                temp = Front;
                Front = Right;
                Right = Back;
                Back = Left;
                Left = temp;
                break;

            case "y'":
                Console.Error.WriteLine($"Moving counter y");
                temp = Front;
                Front = Left;
                Left = Back;
                Back = Right;
                Right = temp;
                break;

            case "z'":
                Console.Error.WriteLine($"Moving counter z");
                temp = Top;
                Top = Right;
                Right = Down;
                Down = Left;
                Left = temp;
                break;

            case "z":
                Console.Error.WriteLine($"Moving z");
                temp = Top;
                Top = Left;
                Left = Down;
                Down = Right;
                Right = temp;
                break;

            default:
                break;
        }
    }

    public string GetPositionOfFace(string face)
    {
        if (Top == face)
        {
            return "U";
        }
        else if (Down == face)
        {
            return "D";
        }
        else if (Right == face)
        {
            return "R";
        }
        else if (Left == face)
        {
            return "L";
        }
        else if (Front == face)
        {
            return "F";
        }
        else if (Back == face)
        {
            return "B";
        }
        else
        {
            return "";
        }
    }
}