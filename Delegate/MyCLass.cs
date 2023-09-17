namespace Delegate;

public class MyCLass
{
    private string inputString;

    public MyCLass(string inputString)
    {
        this.inputString = inputString;
    }

    public void Space(string str)
    {
        string spacedStr = string.Join("_", str.ToCharArray());
        Console.WriteLine(spacedStr);
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        Console.WriteLine(reversedStr);
    }
}