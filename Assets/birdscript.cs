using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public logic logics;
    public bool alive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        logics = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && alive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logics.gameOver();
        alive = false;
    }

   
}
