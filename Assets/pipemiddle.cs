using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddle : MonoBehaviour
{
    public logic logics;

    // Start is called before the first frame update
    void Start()
    {
        logics = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logics.addScore(1);
        }
        
    }
}
