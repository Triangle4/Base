using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptManager: GameLoop
{
    private Player player = new Player();
    public static ScriptManager manager;
    
    public override void Singleton()
    {
        manager = this;
    }
    public override void OnStart()
    {
        player.Start();
    }



    // ============================================================================== Update ======================================================================
    private List<IUpdate> updates = new List<IUpdate>();
    public override void OnUpdate()
    {
        player.Update();
    }
    public void Add(IUpdate update)
    {
        updates.Add(update);
    }
    public bool HasUpdate(IUpdate update)
    {
        return updates.Contains(update);
    }
    public void Remove(IUpdate update)
    {
        updates.Remove(update);
    }
}