using UnityEngine;
using System;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "KTH/Input", fileName = "inputReader")]
public class KTH_InputReader : ScriptableObject
{
    public event Action<Vector2> MoveEvent;

    public void OnMove(InputAction.CallbackContext ctx)
    =>MoveEvent?.Invoke(ctx.ReadValue<Vector2>());
}
