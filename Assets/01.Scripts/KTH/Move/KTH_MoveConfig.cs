using UnityEngine;

[CreateAssetMenu(fileName = "KTH_MoveConfig", menuName = "KTH/MovementConfig")]
public class KTH_MoveConfig : ScriptableObject
{
    [Min(0)] public float speed;
}
