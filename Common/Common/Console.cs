using System;
public class Console
{
    public void ListMenus(string[] arr)
    {
        int i = 0;
        foreach (string str in arr)
        {
            i += 1;
            System.Console.WriteLine($"{i} {str}");
        }
    }
    public int ReadInt(string msg)
    {
        System.Console.WriteLine(msg);
        string input= System.Console.ReadLine();
        int output=0;
        int.TryParse(input,out output);
        return output;
    }
     public string ReadString(string msg)
    {
        System.Console.WriteLine(msg);
        string input= System.Console.ReadLine();
        return input;
    }
}