using System;

public class Game
{
    private Transform player = new Transform();
    private Vector2Int position;
    public void Start()
    {
        position = new Vector2Int(System.Console.CursorLeft, System.Console.CursorTop);
        
        ProcessHandler();
        Singleton();
        OnAwake();
        OnEnable();
        OnStart();
    }
    public void Loop()
    {
        OnEarlyUpdate();
        OnUpdate();
        OnLateUpdate();
    }
    void ProcessHandler()
    {
        
    }
    void Singleton()
    {

    }
    void OnAwake()
    {

    }
    void OnEnable()
    {
        
    }
    void OnStart()
    {

    }
    void OnEarlyUpdate()
    {

    }
    void OnUpdate()
    {
        if(Input.GetKey(ConsoleKey.Escape))
            Application.Quit();
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
    void OnLateUpdate()
    {

    }
    void OnFixedUpdate()
    {

    }
    
}