using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptManager
{
    List<iProcess> process = new List<iProcess>();
    List<iBehaviour> Behaviour = new List<iBehaviour>();
    
    void GetTypes()
    {
        var proc = typeof(iProcess);
        var procTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes()).Where(type => proc.IsAssignableFrom(type) && type.IsClass);
        foreach (var b in procTypes)
        {
            process.Add(Activator.CreateInstance(b) as iProcess);
        }

        var behaviour = typeof(iBehaviour);
        var behaviorTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes()).Where(type => behaviour.IsAssignableFrom(type) && type.IsClass);
        foreach (var a in behaviorTypes)
        {
            Behaviour.Add(Activator.CreateInstance(a) as iBehaviour);
        }   
    }
    public void Start()
    {
        GetTypes();
        process.ForEach(a => a.Initialize());  
        Behaviour.ForEach(b => b.Start());  
    }
    public void Loop()
    {
        process.ForEach(a => a.Refresh()); 
        Behaviour.ForEach(b => b.Update());  
    }
}