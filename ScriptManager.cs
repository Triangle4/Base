using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptManager
{
    List<iBehaviour> behaviorMap = new List<iBehaviour>();
    
    void GetTypes()
    {
        var behaviour = typeof(iBehaviour);
        var behaviorTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes()).Where(type => behaviour.IsAssignableFrom(type) && type.IsClass);
        foreach (var i in behaviorTypes)
        {
            behaviorMap.Add(Activator.CreateInstance(i) as iBehaviour);
        }
           
    }
    public void Start()
    {
        GetTypes();
        behaviorMap.ForEach(b => b.Start());  
    }
    public void Loop()
    {
        behaviorMap.ForEach(b => b.Update());  
    }
}