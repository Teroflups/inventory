using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "InventorySO", menuName = "New InventoryItem")]
public class InventorySO : ScriptableObject
{
    [field: SerializeField] public string Name {  get; private set; }
    [field: SerializeField] public int Cost {  get; private set; }
    [field: SerializeField] public Sprite Icon {  get; private set; }
    [field: SerializeField] public TypeThing Things {  get; private set; }
    [field: SerializeField] public int States { get; private set; }

    public enum TypeThing
    {
    Weapon,
    Food,
    Armor,
    Materials
    }

}
