using UnityEngine;
using UnityEngine.UI;


public class InventoryUI : MonoBehaviour
{
   [field: SerializeField] public  GameObject _inventoryPanel;
   [field: SerializeField] public GameObject _inventorySlotPrefab {get;private set;}
   [field: SerializeField] public Transform _inventoryGrid {get; private set;}
    private Inventory _inventory;
    private Player _character;

   private void Start(){
        _inventory = FindAnyObjectByType<Player>().GetComponent<Inventory>();
        _character = FindAnyObjectByType<Player>().GetComponent<Player>();
         UpdateInventory();
   }

   public void UpdateInventory(){
        ClearItemSlots();
        CreateItemSlot();  
   }


   private void ClearItemSlots()
   {
        foreach (Transform _child in _inventoryGrid )
        {
            Destroy(_child.gameObject);
        }
   }

   public void CreateItemSlot()
   {
        foreach (ItemsData item in _inventory._items)
        {
            GameObject _itemSlot =  Instantiate(_inventorySlotPrefab, _inventoryGrid);
            SetItemSlot(_itemSlot, item);
        }
   }


   private void SetItemSlot(GameObject _itemSlot, ItemsData _item)
   {
        Image _itemIcon = _itemSlot.transform.Find("ItemIcon").GetComponent<Image>();
        Text _itemAmountText = _itemSlot.transform.Find("ItemAmount").GetComponent<Text>();

        if (_itemIcon != null){
            _itemIcon.sprite =  _item._icon;}

        if(_itemAmountText !=null){
          _itemAmountText.text = _item._itemAmount > 1 ? _item._itemAmount.ToString() : "";}

        Button _itemButton = _itemSlot.GetComponentInChildren<Button>();

        if( _itemButton != null ){
            _itemButton.onClick.AddListener(() => UseItem(_item));}
   }

   private void UseItem(ItemsData _item)
   {
        if(_item is WeaponData){_character.EquipWeapon(_item as WeaponData);}
        UpdateInventory();
   }

}
