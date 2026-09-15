using System;
using UnityEditor.SceneManagement;
using UnityEngine;

public enum InteractionType
{
    Object,
    Item
}

public class KTH_InteractionChecker : MonoBehaviour
{

    private KTH_IInteraction interaction;
    public bool IsInteracting { get; private set; } = false;
    [SerializeField] private InteractionType interactionType;
    
    private void Awake()
    {
        if (!TryGetComponent(out interaction))
            Debug.LogError($"{name}: no component implementing {nameof(KTH_IInteraction)} found.", this);
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        IsInteracting = true;
        interaction?.OnInteractionEnter();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        IsInteracting = false;
        interaction?.OnInteractionExit();
    }

    public void TryInteract()
    {
        if (!IsInteracting) return;

        interaction?.Interact();

        if (interactionType == InteractionType.Item)
            Destroy(gameObject);
    }
}
