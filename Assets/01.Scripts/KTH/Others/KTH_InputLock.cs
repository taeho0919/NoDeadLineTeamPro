using UnityEngine;

public class KTH_InputLock : MonoBehaviour
{
    public static KTH_InputLock instance;

    public bool IsLocked { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void Lock() => IsLocked = true;
    public void Unlock() => IsLocked = false;
}
