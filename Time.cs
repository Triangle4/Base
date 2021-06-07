using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Time : iProcess
{
    
    public static float time;
    public static float framerate;
    int frames = 0;
    float tick;
    static float _deltaTime;
    public static float deltaTime
    {
        get{return _deltaTime;}
        private set{_deltaTime = value;}
    }

    Stopwatch stopwatch = new Stopwatch();
    
    public void Initialize()
    {
        stopwatch.Start();        
    }
    float refreshRate = 30f;
    public void Refresh()
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
    public void Print()
    {
        if(Application.DebugMode())
            Debug.Log("Up Time "  + time.ToString("F4") + "\t Framerate " + framerate.ToString("F0") + " FPS", true, 0);
    }
}