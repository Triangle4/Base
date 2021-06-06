
using System;

public class Application
{
    private static bool running = true;
    private static bool debugMode = false;
    private static bool showCursor = false;

    private static Input input = new Input();

    private static Transform player = new Transform();
    private static Vector2Int position;
    static void Main (string [] args)
    {
        Start();
        Loop();
        Termination();
    }
    static void Start()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF32;
        Debug.Initialize();
        Cursor(showCursor);
        position = new Vector2Int(System.Console.CursorLeft, System.Console.CursorTop);
        Time.Init();
        ProcessHandler();
        Singleton();
        OnAwake();
        OnEnable();
        OnStart();
    }
    static void Loop()
    {
        while (running)
        {
            Time.ProcessTime();
            OnEarlyUpdate();
            OnUpdate();
            OnLateUpdate();
        }
    }
    static void ProcessHandler()
    {
        
    }
    static void Singleton()
    {

    }
    static void OnAwake()
    {

    }
    static void OnEnable()
    {
        
    }
    static void OnStart()
    {

    }
    static void OnEarlyUpdate()
    {

    }
    static void OnUpdate()
    {
        if(Input.GetKey(ConsoleKey.Escape))
            running = false;
        if(Input.GetKey(ConsoleKey.S))
            position.y += 1;
        if(Input.GetKey(ConsoleKey.W) && position.y > 0)
            position.y -= 1;
        if(Input.GetKey(ConsoleKey.D))
            position.x += 1;
        if(Input.GetKey(ConsoleKey.A) && position.x > 0)
            position.x -= 1;
        player.position = position;
            
    }
    static void OnLateUpdate()
    {

    }
    static void OnFixedUpdate()
    {

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