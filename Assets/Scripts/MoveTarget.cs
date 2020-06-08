using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public float speed;

    public Transform[] movePoints;
    private int randomSpot;
    private float waitTime;
    private float startWaitTime = 0;
   
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, movePoints.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movePoints[randomSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movePoints[randomSpot].position) < 0.2f)
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, movePoints.Length);
                waitTime = startWaitTime;
            } else
            {
                waitTime -= Time.deltaTime;
            }
    }

}
