using System;
using UnityEngine;

public class KTH_InteractionChecker : MonoBehaviour
{
    [SerializeField] private GameObject targets;
    public bool isInteracting{get; private set;}=false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInteracting = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInteracting = false;
        }
    }
}
