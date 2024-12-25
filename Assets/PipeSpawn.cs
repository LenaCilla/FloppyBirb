using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float timer = 0;
    public float heightOffset = 10;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {

        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }

}
