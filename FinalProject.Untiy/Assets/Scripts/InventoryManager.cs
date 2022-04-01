using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Transform inventoryPanel;
    public List<InventorySlot> slots = new List<InventorySlot>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < inventoryPanel.childCount; i++)
        {
            if(inventoryPanel.GetChild(i).GetComponent<InventorySlot>() != null)
            {
                slots.Add(inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
