using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceSpawnerscript : MonoBehaviour
{
    public GameObject Fence;
    public float spwanRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnFenc();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnFenc();
            timer = 0;
        }



    }
    void spawnFenc() 
    {
        float lowestPoint = transform.position.y - heightOffset;
        float HighestPoint = transform.position.y + heightOffset;

        Instantiate(Fence, new Vector3(transform.position.x,Random.Range(HighestPoint,lowestPoint),0) ,transform.rotation);
    }
}
