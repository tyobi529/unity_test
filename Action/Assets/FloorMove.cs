using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    int counter = 0;
    float move;

    private void Start()
    {
        move = Random.Range(-0.03f, 0.03f);
    }

    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == 200)
        {
            counter = 0;
            move *= -1;
        }
    }
}
