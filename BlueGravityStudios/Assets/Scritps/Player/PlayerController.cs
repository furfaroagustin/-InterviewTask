using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private bool canMove = true; // Variable para controlar el movimiento

    void Update()
    {
        if (canMove) // Verifica si el jugador puede moverse
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0) * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }

    // Método para configurar si el jugador puede moverse o no
    public void SetCanMove(bool canMove)
    {
        this.canMove = canMove;
    }
}
