using UnityEngine;
using System.Collections.Generic;

public class Store : MonoBehaviour
{
    public List<ClothingItem> availableItems = new List<ClothingItem>();
    public GameObject productButtonPrefab;
    public Transform productButtonContainer;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        foreach (Transform child in productButtonContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (ClothingItem item in availableItems)
        {
            GameObject button = Instantiate(productButtonPrefab, productButtonContainer);
            button.GetComponent<ProductB>().SetupButton(item);
        }
    }
}
