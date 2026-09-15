using System;
using UnityEngine;

public class KTH_PlayerCTRL : MonoBehaviour
{
    [SerializeField]private KTH_InputReader inputReader;
    private KTH_IMovable mover;
    private Vector2 curMoveInput;

    private void Awake()
    {
        if (!TryGetComponent(out mover))
            Debug.LogError($"{name}: no component implementing {nameof(KTH_IMovable)} found.", this);

        if (inputReader == null)
            Debug.LogError($"{name}: {nameof(inputReader)} is not assigned.", this);
    }

    private void OnEnable() => inputReader.MoveEvent += HandleMove;

    private void OnDisable() => inputReader.MoveEvent -= HandleMove;

    private void HandleMove(Vector2 input)
    {
        curMoveInput = input;
    }

    private void FixedUpdate()
    {
        if (KTH_InputLock.instance.IsLocked)
        {
            mover.Move(Vector2.zero);
            return;
        }

        mover.Move(curMoveInput);
    }
}
