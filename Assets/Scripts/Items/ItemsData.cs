using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(fileName ="New Item" , menuName = "Item/Item")]
public class ItemsData : ScriptableObject
{
    public string _itemName;
    public Sprite _icon;
    public float _itemAmount;
    public bool _isStackable;
    public float _maxStackableAmount = 1;
}

