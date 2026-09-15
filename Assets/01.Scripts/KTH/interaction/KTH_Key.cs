using Unity.VisualScripting;
using UnityEngine;

public class KTH_Key : MonoBehaviour,KTH_IInteraction
{
    [SerializeField] private ItemSO _itemSo;
    
    public void OnInteractionEnter()
    {
        
    }

    public void OnInteractionExit()
    {
        
    }

    public void Interact()
    {
        KTH_InventoryManager.instance.AddItem(_itemSo);
        
    }
}
