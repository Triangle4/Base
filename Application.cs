
using System;

public class Application
{
    private static bool running = true;
    private static bool debugMode = true;
    private static bool showCursor = false;

    private static Input input = new Input();
    private static ScriptManager scriptManager = new ScriptManager();
    static void SetConsole()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    }
    static void Initialize()
    {
        Cursor(showCursor);
        Debug.Initialize();
        scriptManager.Start();
    }
    static void Main (string [] args)
    {
        SetConsole();
        Initialize();
        while (running)
        {
            scriptManager.Loop();
        }
        Termination();
    }
    public static void Quit()
    {
        running = false;
    }
    static void Termination()
    {
        Input.keyListener.Dispose();
        Debug.Log("Application Terminated. Press any key to quit...\n", false, 1);
    }
    public static bool DebugMode()
    {
        return debugMode;
    }
    public static void Cursor(bool visible = false)
    {
        System.Console.CursorVisible = visible;
    }
}