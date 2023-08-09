using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [SerializeField] List<ClothingItem> informationItems;
    [SerializeField] GameObject templateObjectsStore;
    [SerializeField] TextMeshProUGUI textCoinsTotals;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Total Coins"))
        {
            PlayerPrefs.SetInt("Total Coins", 900);
        }

        foreach (var item in informationItems)
        {
            var templateItem = Instantiate(templateObjectsStore, transform).GetComponent<PlantillaItemStore>();
            templateItem.image.sprite = item.sprite;
            templateItem.nameProduct.text = item.titleName; // Usar item.titleName en lugar de titleName
            templateItem.textPrice.text = item.price.ToString();
        }
    }
    private void Update()
    {
        textCoinsTotals.text = PlayerPrefs.GetInt("CoinsTotals").ToString();
    }
}
