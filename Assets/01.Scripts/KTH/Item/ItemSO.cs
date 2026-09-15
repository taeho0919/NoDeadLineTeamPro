using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "KTH/ItemSO")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    [TextArea]
    public string itemDescription;
    public Sprite itemSprite;
    
}
