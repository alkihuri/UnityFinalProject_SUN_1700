using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food_Item", menuName = "Inventory/Items/New Food Item")]

public class Food_ItemScript : ItemLogic
{
    public float healAmount;

    private void Start()
    {
        itemType = itemType.food;
    }
}
