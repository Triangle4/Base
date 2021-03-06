public interface iBehaviour
{
    void Awake();
    void Enable();
    void Start();
    void Update();
    void FixedUpdate();
    void EarlyUpdate();
    void LateUpdate();
}
public interface iProcess
{
    void Initialize();
    void Refresh();
}
