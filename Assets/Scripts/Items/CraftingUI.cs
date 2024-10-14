using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class CraftingUI : MonoBehaviour
{
    [SerializeField] private GameObject _craftingPanel;
    [SerializeField] private GameObject _recipeSlotCrafting;
    [SerializeField] private Transform _recipesContainer;

    private Inventory _inventory;
    private InventoryUI _inventoryUI;

    private void Start()
    {   _inventory = FindAnyObjectByType<Player>().GetComponent<Inventory>();
       _inventoryUI = GameObject.Find("Inventory").GetComponent<InventoryUI>();
        UpdateCraftingUI();
    }

    public void UpdateCraftingUI(){
        ClearRecipeSlots();

        foreach (RecipeData recipe in GetAllRecipe())
        {
            CreateRecipeSlot(recipe);
        }
    }

    private void ClearRecipeSlots(){
        foreach (Transform _child in _recipesContainer)
        {
            Destroy(_child.gameObject);
        }
    }

    private void CreateRecipeSlot(RecipeData _recipeData){
        GameObject _recipeSlot = Instantiate(_recipeSlotCrafting,_recipesContainer);
        Image _slotImage = _recipeSlot.transform.Find("RecipeItem").GetComponent<Image>();
        
        if(_slotImage != null)
        {
            _slotImage.sprite = _recipeData._iconRecipe;
        }
        _recipeSlot.transform.Find("RecipeName").GetComponent<Text>().text = _recipeData._recipeName;
        Button _craftButton = _recipeSlot.GetComponentInChildren<Button>();
        _craftButton.onClick.AddListener(() => CraftItem(_recipeData)); 
    }

    private void CraftItem(RecipeData _recipeData){
        if(_inventory.HasIngredient(_recipeData)){
            _inventory.AddItem(_recipeData._resultItem);
            _inventory.RemoveIngredients(_recipeData);
            Debug.Log("Предмет скравчен:"+ _recipeData._resultItem._itemName);
        }
        else{Debug.Log("Недостаточно ресурсов");}
    }
    private RecipeData[] GetAllRecipe(){
        return Resources.LoadAll<RecipeData>("Recipes");
    }
}
