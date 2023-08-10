using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogueSystem : MonoBehaviour
{
    public GameObject interactionText;
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public PlayerController playerController; // Referencia al PlayerController

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mercader"))
        {
            interactionText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Mercader"))
        {
            interactionText.SetActive(false);
            dialoguePanel.SetActive(false);
            playerController.SetCanMove(true); // Reactivar movimiento del jugador
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && interactionText.activeSelf)
        {
            interactionText.SetActive(false);
            dialoguePanel.SetActive(true);
            playerController.SetCanMove(false); // Pausar movimiento del jugador
            dialogueText.text = "Hello, I am the merchant, do you want to buy or sell something?";
        }
    }

    public void ExitDialogue()
    {
        dialoguePanel.SetActive(false);
        playerController.SetCanMove(true); // Reactivar movimiento del jugador
    }

    public void BuyButton()
    {
        SceneManager.LoadScene("Store");
    }

    public void SellButton()
    {
        SceneManager.LoadScene("StoreSell");
    }
}
