using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public  List<ItemsData> _items = new List<ItemsData>();



    public void AddItem(ItemsData _item){
        _items.Add(_item);

        Debug.Log("Добавлен в инвентарь" + _item._itemName);
    }

    public void RemoveItem(ItemsData _item) {
        _items.Remove(_item);
        Debug.Log("Удален из инвентаря " + _item._itemName);
    }
}
