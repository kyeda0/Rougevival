using UnityEngine;


[CreateAssetMenu(fileName ="New Item" , menuName = "Item/Item")]
public class ItemsData : ScriptableObject
{
    public string _itemName;
    public string _itemDescription;
    public Sprite _icon;
    public ItemType _itemType;

    public enum ItemType{
        _weapon,
        _armor,
        _consumable
    }
}
