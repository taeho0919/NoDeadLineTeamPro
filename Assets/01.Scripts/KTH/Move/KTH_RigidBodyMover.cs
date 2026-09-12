using System;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class KTH_RigidBodyMover : MonoBehaviour , KTH_IMovable
{
    [SerializeField]private KTH_MoveConfig  config;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (config == null)
            Debug.LogError($"{name}: {nameof(config)} is not assigned.", this);
    }

    public void Move(Vector2 direction)
    {
        rb.linearVelocity = direction.normalized * config.speed;
    }
}
