using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f; // velocidad
    public float topHeight; // altura por arriba
    public float botHeight; // altura por debajo
    public bool useArrowKeys = false; 

    void Update()
    {
        MovePaddle();

    }
    void MovePaddle()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, ConstraintPaddle(), this.gameObject.transform.position.z);
    }
    float ConstraintPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);

        if (nuevaY > topHeight)
        {
            nuevaY = topHeight;
        }
        if (nuevaY < botHeight)
        {
            nuevaY = botHeight;
        }
        return nuevaY;
    }

    float PaddleDirection()
    {
        float direccion = 0f;
        if (useArrowKeys == true)
        {
            if (Input.GetKey(KeyCode.UpArrow)) // funcion para que la pala vaya para arriba con la flecha
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.DownArrow)) // funcion para que la pala vaya para abajo con la flecha
            {
                direccion = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W)) // funcion para que la pala vaya para arriba con la W
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S)) // funcion para que la pala vaya para abajo con la S
            {
                direccion = -1f;
            }
        }
        return direccion;
    }
}
