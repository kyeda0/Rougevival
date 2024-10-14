using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public  List<ItemsData> _items = new List<ItemsData>();
    [SerializeField] private float _maxSlots ;   
    [SerializeField] private float _maxAmountItem;
    private InventoryUI _inventoryUI;

    private void Start(){_inventoryUI = GameObject.Find("Inventory").GetComponent<InventoryUI>();}
    public void AddItem(ItemsData _newItem){
        if(_items.Count >= _maxSlots){
            Debug.Log("Инвентарь переполнен");
            return;
        }
        else{_items.Add(_newItem);}
        ItemsData _existingItem = _items.Find(item => item._itemName == _newItem._itemName);
            if(_existingItem !=null){
                if(_existingItem._itemAmount + _newItem._itemAmount <= _maxAmountItem){_existingItem._itemAmount += _newItem._itemAmount;}

                else{Debug.Log("Превышен лимит по количеству предметов в слоте");}
            }
        _inventoryUI.UpdateInventory();
    }

    public void RemoveItem(ItemsData _itemToRemove){
        ItemsData _existingItem = _items.Find(item => item._itemName == _itemToRemove._itemName);
        if(_existingItem != null){
            _existingItem._itemAmount--;
            if(_existingItem._itemAmount <=0){
                _items.Remove(_existingItem);
            }
        }
        _inventoryUI.UpdateInventory();
    }

     public void RemoveIngredients(RecipeData _recipeData)
    {
        foreach (var ingredient in _recipeData._ingredients)
        {
            RemoveItem(ingredient._itemIngredient);

        }
        _inventoryUI.UpdateInventory();
    }

    public bool HasIngredient(RecipeData _recipeData){
        foreach (var _ingredient in _recipeData._ingredients)
        {
            ItemsData _existingItem = _items.Find(item => item._itemName == _ingredient._itemIngredient._itemName);
            if(_existingItem == null || _existingItem._itemAmount <=_ingredient._amount){return false;}
        }
        return true;
    }
}
