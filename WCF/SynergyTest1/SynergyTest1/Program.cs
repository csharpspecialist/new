


using System;

public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }

    public Path Cd(string newPath)
    {
        Path pathStr = new Path(this.CurrentPath);
        if (newPath == null | newPath == string.Empty)
        {
            throw new System.NotSupportedException("Waiting to be implemented.");
        }

        string patternUp = "([\\.]{2}/)+[a-zA-z]+";
        string patternDown = @"/([a-zA-z]*)";

        var matchesUp = Regex.Matches(newPath, patternUp);
        var matchesDown = Regex.Matches(newPath, patternDown);

        if (matchesUp.Count > 0)
        {
            var countUp = newPath.Count(c => c == '.');

            pathStr.CurrentPath = pathStr.CurrentPath.Substring(0, pathStr.CurrentPath.Length - countUp);
            pathStr.CurrentPath = pathStr.CurrentPath + "/" + newPath.Replace("../", "");
        }
        else
        {
            pathStr.CurrentPath = pathStr.CurrentPath + newPath.Replace("../", "");
        }
        return new Path(pathStr.CurrentPath);
    }

    public static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        path.Cd("../x");
        Console.WriteLine(path.CurrentPath);
    }
}