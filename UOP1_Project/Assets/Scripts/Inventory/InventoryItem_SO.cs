using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Assets", menuName ="Game/InventoryItem")]
public class InventoryItem_SO : ScriptableObject
{
    public enum eItemType
    {
        Health,
        Ingredient,
        Money,
        Clutter
    }

    /// <summary>
    /// The type of the item
    /// </summary>
    public eItemType ItemType;
    /// <summary>
    /// A reference to the prefab that can be spawned in the world if the player drops the item. 
    /// </summary>
    public GameObject gameWorldRuntimePrefab;
    /// <summary>
    /// If the item is a consumable like health or money, this value represents the amount the
    /// player's value of that type should be increased. Eg, if health then heal 10 points. 
    /// </summary>
    public int increaseAmount;
}
