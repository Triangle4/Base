using System;
using System.Threading;
using System.Collections.Generic;
public class Input
{
    public static KeyListener keyListener;
    
    
    public Input()
    {
        keyListener = new KeyListener();
    }

    public static bool GetKey(ConsoleKey key)
    {
        
        if(!keyListener.keys.ContainsKey(key))
            keyListener.keys.Add(key, false);
        if(keyListener.keys.ContainsKey(key))
        {
            if(keyListener.keys[key])
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                Debug.Log("Key" + key, false, 20);
                keyListener.keys.Remove(key);
                return true;
            }
        }
        
        return false;
    }
}

public class KeyListener
{
    public Dictionary<ConsoleKey, bool> keys = new Dictionary<ConsoleKey, bool>();

    ConsoleKeyInfo cki = new ConsoleKeyInfo();
    Thread thread;
    private bool active;
    private int parsingInterval = 100;
    public KeyListener()
    {
        active = true;
        thread = new Thread(new ThreadStart(Listen));
        thread.Start();
    }
    void Listen()
    {
        do
        {
            while (!Console.KeyAvailable && active)
                Thread.Sleep(parsingInterval);
            if(active)
            {
                cki = Console.ReadKey(true);
                foreach (KeyValuePair <ConsoleKey, bool> kvp in keys)
                {
                    keys[kvp.Key] = cki.Key == kvp.Key;
                }
            }

        } while (active);
    }
    public void Dispose()
    {
        active = false;
        Debug.Log("Listener Terminated", false, 2);
        Debug.Log(" ", false, 3);
    }
    public void Interval(int duration)
    {
        parsingInterval = duration;
    }
}