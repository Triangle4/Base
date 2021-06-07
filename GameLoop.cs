public class GameLoop
{
    public void Start()
    {
        Singleton();
        OnAwake();
        OnEnable();
        OnStart();
    }
    public void Loop()
    {
        OnEarlyUpdate();
        OnUpdate();
        OnLateUpdate();
    }
    
    public virtual void Singleton(){}
    public virtual void OnAwake(){}
    public virtual void OnEnable(){}
    public virtual void OnStart(){}
    public virtual void OnEarlyUpdate(){}
    public virtual void OnUpdate(){}
    public virtual void OnLateUpdate(){}
    public virtual void OnFixedUpdate(){}
}