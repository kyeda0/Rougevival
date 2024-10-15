
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] ItemsData _currentItem;
    private Inventory _inventory;
    void Start()
    {
        _inventory = FindAnyObjectByType<Player>().GetComponent<Inventory>();
    }


    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.CompareTag("Player") && _currentItem._itemAmount < _inventory._maxAmountItem && _inventory._items.Count < _inventory._maxSlots){
            _inventory.AddItem(_currentItem);
            Destroy(this.gameObject);
        }
    }
}
