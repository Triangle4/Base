using System;

public class Debug
{
    static int row;
    static int column;
    public static void Initialize()
    {
        row = System.Console.CursorTop;
        column = System.Console.CursorLeft;
    }
    public static void Log(string data, bool clear, int line)
    {
        if(clear)
            ClearLine(row + line);
        System.Console.SetCursorPosition(0, row + line);
        System.Console.Write(data);
    }
    static void ClearLine(int line)
    {
        System.Console.Write(new string(' ', System.Console.BufferWidth));
        System.Console.SetCursorPosition(0, line);
    }
}