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
            var instantiatedItem = Instantiate(templateObjectsStore, transform);
            var plantillaItemScript = instantiatedItem.GetComponent<PlantillaItemStore>();

            plantillaItemScript.image.sprite = item.sprite;
            plantillaItemScript.titleName.text = item.titleName;
            plantillaItemScript.textPrice.text = item.price.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        textCoinsTotals.text = PlayerPrefs.GetInt("coinsTotal").ToString();
    }
}