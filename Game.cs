using System;

public class Game : GameLoop
{
    private Player player = new Player();
    
    public override void OnStart()
    {
        player.Start();
    }
    public override void OnUpdate()
    {
        player.Update();
    }
}