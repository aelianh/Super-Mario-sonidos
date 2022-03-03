
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    //variable para controlar la velocidad del goomba
    public float movementSpeed = 4.5f;
    //variable para controlar la direccion (X)
    private int directionX = 1;
    
    //variable para almanecar el rigid body del enemigo
    private Rigidbody2D rigidBody;

    public bool isAlive = true;
    private GameManager gameManager;
    void Awake()
    {
        rigidBody = GetComponent <Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isAlive)
        {
             //añade velocidad en el eje x
       rigidBody.velocity = new Vector2(directionX * movementSpeed, rigidBody.velocity.y);
        }
        else 
        {
            rigidBody.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if(hit.gameObject.tag =="Pared" || hit.gameObject.layer == 6)
            {
                Debug.Log("la mascota ha explotado");

                if(directionX == 1 )
                {
                    directionX = -1;
                }
                else 
                {
                    directionX = 1;
                }
            }
        else if(hit.gameObject.tag =="MuereMario")
        {
            Destroy(hit.gameObject);
            gameManager.DeathMario();
        }
    }
}
