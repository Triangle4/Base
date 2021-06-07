using System;
public class Player : GameObject
{
    private Vector2Int position;
    public void Start()
    {
        position = new Vector2Int(System.Console.CursorLeft, System.Console.CursorTop);
    }
    public void Update()
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
        transform.position = position;
    }
}