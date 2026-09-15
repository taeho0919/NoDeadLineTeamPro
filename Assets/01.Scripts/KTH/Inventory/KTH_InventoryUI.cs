using UnityEngine;

public class KTH_InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private KeyCode toggleKey = KeyCode.E;

    private bool isOpen;

    private void Start()
    {
        SetOpen(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
            SetOpen(!isOpen);
    }

    private void SetOpen(bool open)
    {
        isOpen = open;
        inventoryPanel.SetActive(open);

        if (open)
            KTH_InputLock.instance.Lock();
        else
            KTH_InputLock.instance.Unlock();
    }
}
