using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum itemType { food, weapon, instrument, resource, component, equipment, clothes}
public class ItemLogic : ScriptableObject
{
    public itemType itemType;
    public string itemName;
    public int maxAmount;
    public string itemDescription;
}
