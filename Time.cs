using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Time
{
    
    public static float time;
    public static float framerate;
    static int frames = 0;
    static float tick;
    public static float _deltaTime;
    public static float deltaTime
    {
        get{return _deltaTime;}
        private set{_deltaTime = value;}
    }

    static Stopwatch stopwatch = new Stopwatch();

    public static void Init()
    {
        stopwatch.Start();
    }
    static float refreshRate = 30f;
    public static void ProcessTime()
    {
        time = stopwatch.ElapsedMilliseconds / 1000f;
        if(time - tick >= 1f / refreshRate)
        {
            tick = time; 
            framerate = frames * refreshRate;
            frames = 0;
        }
        frames++;
        Print();
    }
    public static void Print()
    {
        if(Application.DebugMode())
            Debug.Log("Up Time "  + time.ToString("F4") + "\t Framerate " + framerate.ToString("F0") + " FPS", true, 0);
    }
}