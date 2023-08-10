using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlantillaItemStore : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI textPrice;
    public TextMeshProUGUI titleName;
    public Button buttonBuy;
    int precio;
    int monedaTotales;
    //inventory
    public InventorySystem inventorySystem;
    // Start is called before the first frame update
    void Start()
    {
        precio = int.Parse(textPrice.text);
    }

    // Update is called once per frame
    void Update()
    {
        monedaTotales = PlayerPrefs.GetInt("coinsTotal");
        if (precio > monedaTotales)
        {
           // buttonBuy.interactable = false;
        }
    }
    public void Buy(string itemName)
    {
        monedaTotales -= precio;
        PlayerPrefs.SetInt("coinsTotal", monedaTotales);
        inventorySystem.AddToInventory(itemName);
    }
}
