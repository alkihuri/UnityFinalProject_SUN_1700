using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum itemType { food, weapon, instrument, resource, component, equipment, clothes}
public class ItemLogic : ScriptableObject
{
    
    public string itemName;
    public int maxAmount;
    public GameObject itemPrefab;
    public itemType itemType;
    public string itemDescription;
}
