using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    [SerializeField] public List<Image> slots = new List<Image>();

    [SerializeField] InventorySO[] items;
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] TextMeshProUGUI @class;
    [SerializeField] TextMeshProUGUI cost;
    [SerializeField] TextMeshProUGUI state;
    [SerializeField] Image mainImage;
    int id;
    public void Gambling()
    {
        if (id >= slots.Count) return;
        InventorySO currentItem = items[Random.Range(0, items.Length)];
        slots[id].sprite = currentItem.Icon;
        name.text = currentItem.Name;
        @class.text = currentItem.Things.ToString();
        cost.text = currentItem.Cost.ToString();
        mainImage.sprite = currentItem.Icon;
        state.text = currentItem.States.ToString();
        id++;
    }
}
