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
        if (!PlayerPrefs.HasKey("Coins"))
        {
            PlayerPrefs.SetInt("Coins", 900);
        }
        var  templateItem = templateObjectsStore.GetComponent<PlantillaItemStore>();
        foreach (var item in informationItems)
        {

            templateItem.image.sprite = item.sprite;
            templateItem.nameProduct.text = item.titleName;
            templateItem.textPrice.text = item.price.ToString();

            Instantiate(templateItem, transform);
        }
    }
    private void Update()
    {
        textCoinsTotals.text = PlayerPrefs.GetInt("Coins:").ToString();
    }
}
