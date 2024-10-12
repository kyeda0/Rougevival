using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public  List<ItemsData> _items = new List<ItemsData>();
    private InventoryUI _inventoryUI;

    private void Start(){_inventoryUI = GameObject.Find("Inventory").GetComponent<InventoryUI>();
}
    public void AddItem(ItemsData _item){
        _items.Add(_item);
        _inventoryUI.UpdateInventory();
    }

    public void RemoveItem(ItemsData _item) {
        _items.Remove(_item);
        Debug.Log("Удален из инвентаря " + _item._itemName);
    }
}
