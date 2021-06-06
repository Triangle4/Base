public class Transform
{
    private Vector2Int _position = new Vector2Int();
    public int width = 1;
    public int height = 1;
    public char body = '\u25b2';
    public char bodyUp = '\u25b2';
    public char bodyDown = '\u25bc';
    public char bodyRight = '\u25ba';
    public char bodyLeft = '\u25c4';

    public Vector2Int position
    {
        get
        {
            return _position;
        }
        set
        {
            
            int x = value.x - _position.x;
            int y = value.y - _position.y;
            if(x > 0)
            {
                System.Console.SetCursorPosition(value.x - 1, value.y);
                body = bodyRight;
            }
            else if(x < 0)
            {
                System.Console.SetCursorPosition(value.x + 1, value.y);
                body = bodyLeft;
            }
            else if(y > 0)
            {
                System.Console.SetCursorPosition(value.x, value.y - 1);
                body = bodyDown;
            }
            else if(y < 0)
            {
                System.Console.SetCursorPosition(value.x, value.y + 1);
                body = bodyUp;
            }
            System.Console.Write(" ");
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.SetCursorPosition(value.x, value.y);
            System.Console.Write(body);
            
            _position.x = value.x;   
            _position.y = value.y;   
        }
        
    }
}