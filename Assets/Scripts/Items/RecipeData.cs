using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Item" , menuName = "Recipe/Recipe")]
public class RecipeData : ScriptableObject
{
    public string _recipeName;
    public ItemsData _resultItem;
    public float _resultAmount = 1;
    public Sprite _iconRecipe;
    public List<ItemIngredient> _ingredients;
}

[System.Serializable]
public class ItemIngredient{
    public ItemsData _itemIngredient;
    public int _amount;
}

