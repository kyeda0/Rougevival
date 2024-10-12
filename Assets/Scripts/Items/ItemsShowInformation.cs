using Unity.VisualScripting;
using UnityEngine;

public class Inventoryshow : MonoBehaviour
{
    private InventoryUI _inventoryUI;
    [SerializeField] private KeyCode _showButton;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Vector3 _offsett;
    [SerializeField] private float _smoothSpeed;

    private void Start(){
        _inventoryUI = transform.GetComponent<InventoryUI>();
        HideInventory();
    }

    void Update(){
        ShowInventory();
    }
    private void ShowInventory(){
        Vector3 _show = _inventoryUI._inventoryPanel.transform.position + _offset;
        Vector3 _vector = Vector3.Lerp(transform.position,_show,_smoothSpeed);
        transform.position = _vector;
    }

    private void HideInventory(){
        Vector3 _show = _inventoryUI._inventoryPanel.transform.localPosition - _offsett;
        Vector3 _vector = Vector3.Lerp(transform.localPosition,_show,_smoothSpeed);
        transform.localPosition = _vector;
    }
}
