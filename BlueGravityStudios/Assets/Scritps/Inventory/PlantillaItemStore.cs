using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlantillaItemStore : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI textPrice;
    public TextMeshProUGUI nameProduct;
    public Button buttonBuy;
    int price;
    int coinsTotal;

    private void Start()
    {
        price = int.Parse(textPrice.text);
    }
    private void Update()
    {
        price = PlayerPrefs.GetInt("CoinsTotal:");
        if(price>coinsTotal)
        {
            buttonBuy.interactable = false;
        }
    }
    public void Buy()
    {
        coinsTotal -= price;
        PlayerPrefs.SetInt("CoinsTotal", coinsTotal);
    }
}
