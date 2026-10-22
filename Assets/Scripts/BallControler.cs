using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float velocidad = 10f;
    public GameManager gameManager;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = this.gameObject.GetComponent<Rigidbody2D>();
       
       LaunchBall();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.magnitude > velocidad)
        {
            rb.velocity = rb.velocity.normalized * velocidad;
        }
    }

    void LaunchBall()
    {
        bool isRight = false;
        if (Random.value > 0.5f)
        {
            isRight = true;
        }

        float xVelocity = -1;
        if (isRight == true)
        {
            xVelocity = 1;
        }

        float yVelocity = Random.Range(-1f, 1f);
        rb.velocity = new Vector2(xVelocity * velocidad, yVelocity * velocidad);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ball hit");

        gameManager.PuntosP1++;
        gameManager.PuntosP2++;
        gameManager.UpdatePointsText();
    }

}
