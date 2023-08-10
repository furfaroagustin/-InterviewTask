using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryItem
{
    public string itemName;
    public GameObject itemPrefab; // Cambia el tipo a GameObject
}

public class InventorySystem : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();
    public Transform spawnPoint; // Referencia al punto de instanciación

    // Agrega un objeto al inventario
    public void AddToInventory(string itemName)
    {
        InventoryItem item = inventory.Find(i => i.itemName == itemName);
        if (item != null)
        {
            Instantiate(item.itemPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
