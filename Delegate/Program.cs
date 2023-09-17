using Delegate;

public delegate void Func(string str);

public class Run
{
    public void runFunc(Func func, string str)
    {
        func.Invoke(str);
    }
}

internal class Program
{
    private static void Main()
    {
        Console.Write("Enter string: ");
        var str = Console.ReadLine();
        MyCLass cls = new MyCLass(str);

        Func funcDell = new Func(cls.Space);
        Func funcDell2 = new Func(cls.Reverse);

        Run run = new Run();
        run.runFunc(funcDell, str);
        run.runFunc(funcDell2, str);
    }
}