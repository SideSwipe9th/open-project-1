using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem_SO> backpack = new List<InventoryItem_SO>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // If we've entered the trigger collider for a pickup item
        // add it to the backpack, and destroy the item in the world
        // Note: can refactor this to disable if we want to use object pooling
        if (other.tag == "InventoryItem")
        {
            InventoryItem pickupItem;
            if (other.gameObject.TryGetComponent<InventoryItem>(out pickupItem))
            {
                backpack.Add(pickupItem.inventoryItem);
                Destroy(other.gameObject);
            }
        }
    }
}
