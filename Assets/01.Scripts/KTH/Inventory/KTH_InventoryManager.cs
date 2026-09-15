using System;
using System.Collections.Generic;
using UnityEngine;

public class KTH_InventoryManager : MonoBehaviour
{
    public static KTH_InventoryManager instance;

    public event Action<ItemSO> OnItemAdded;
    public event Action<ItemSO> OnItemRemoved;

    private readonly List<ItemSO> items = new List<ItemSO>();
    public IReadOnlyList<ItemSO> Items => items;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

    }

    public void AddItem(ItemSO item)
    {
        items.Add(item);
        Debug.Log(item.ToString());
        OnItemAdded?.Invoke(item);
    }
    public void RemoveItem(ItemSO item)
    {
        if (items.Remove(item))
            OnItemRemoved?.Invoke(item);
    }
}
