using UnityEngine;

public class KTH_Item : MonoBehaviour, KTH_IInteraction
{
    [SerializeField] private ItemSO itemData;

    public void OnInteractionEnter()
    {
    }

    public void OnInteractionExit()
    {
    }

    public void Interact()
    {
        KTH_InventoryManager.instance.AddItem(itemData);
    }
}
