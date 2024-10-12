using UnityEngine;

public class InventoryShow : MonoBehaviour
{
    private InventoryUI _inventoryUI;
    [SerializeField] private KeyCode _showButton;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothSpeed;

    private void Start(){
        _inventoryUI = transform.GetComponent<InventoryUI>();
    }

    private void ShowInventory(){
        Vector3 _show = _inventoryUI._inventoryPanel.transform.position + _offset;

        Vector3 _vector = Vector3.Lerp(transform.position,_show,_smoothSpeed);

        transform.position = _vector;

    }

    private void HideInventory(){

    }
}
