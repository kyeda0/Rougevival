using UnityEngine;


[CreateAssetMenu(fileName ="New Armor" , menuName = "Armor/Armor")]
public class ArmorData : ItemsData
{
    public float _defense;
    public float durability;

    public GameObject _prefabArmor;
}
