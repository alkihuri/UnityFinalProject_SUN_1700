using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ResourceItem  
{ 
    public ResourceItem(Resource newOne)
    {
        item = newOne;
        value = 0;
    } 
    public enum Resource
    {
        sulfur, 
        wood, 
        metal, 
        stone
    }

    public void AddValue(float valueToAdd)
    {
        value += valueToAdd;
    }
    public Resource item;
    public float value; 
}
