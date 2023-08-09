using UnityEngine;
using UnityEngine.UI;

public class ProductB: MonoBehaviour
{
    public Text nameLabel;
    public Text priceLabel;
    public Image iconImage;

    private ClothingItem item;

    public void SetupButton(ClothingItem newItem)
    {
        item = newItem;
        nameLabel.text = item.itemName;
        priceLabel.text = item.price.ToString();
        iconImage.sprite = item.sprite;
    }

    public void OnBuyButtonClick()
    {
        // Aquí puedes implementar la lógica para comprar el producto
        // Actualizar el inventario del jugador, descontar moneda, etc.
    }
}
