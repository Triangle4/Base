public class Vector2
{
    public float x;
    public float y;

    public Vector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public Vector2()
    {
        this.x = 0f;
        this.y = 0f;
    }
    public static Vector2 One()
    {
        return new Vector2(1f,1f);
    }
    public static Vector2 Zero()
    {
        return new Vector2(0f,0f);
    }
}
public class Vector2Int
{
    public int x;
    public int y;

    public Vector2Int(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Vector2Int()
    {
        this.x = 0;
        this.y = 0;
    }
    public static Vector2Int One()
    {
        return new Vector2Int(1,1);
    }
    public static Vector2Int Zero()
    {
        return new Vector2Int(0,0);
    }
}
public class Math
{
    public static int Abs(int n)
    {
        return n > 0 ? n: n* -1;
    }
}

