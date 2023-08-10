using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
 
public class Store : MonoBehaviour
{
    [SerializeField] List<ClothingItem> informationItems;
    [SerializeField] GameObject templateObjectsStore;
    [SerializeField] TextMeshProUGUI textCoinsTotals;

    // Start is called before the first frame update
    private void Start()
    {
        if (!PlayerPrefs.HasKey("coinsTotal"))
        {
            PlayerPrefs.SetInt("coinsTotal", 900);
        }
        var templateItem = templateObjectsStore.GetComponent<PlantillaItemStore>();

        foreach (var item in informationItems)
        {
            templateItem.image.sprite = item.sprite;
            templateItem.titleName.text = item.titleName;
            templateItem.textPrice.text = item.price.ToString();
 
            Instantiate(templateItem, transform);
        }
    }
 
    // Update is called once per frame
    void Update()
    {
        textCoinsTotals.text = PlayerPrefs.GetInt("coinsTotal").ToString();
    }
}