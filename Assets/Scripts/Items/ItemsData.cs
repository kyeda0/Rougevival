using UnityEngine;


[CreateAssetMenu(fileName ="New Item" , menuName = "Item/Item")]
public class ItemsData : ScriptableObject
{
    public string _itemName;
    public string _itemDescription;
    public Sprite _icon;
}
