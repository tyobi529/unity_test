using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    float move_x;
    float move_y;

    // Start is called before the first frame update
    void Start()
    {
        move_x = Random.Range(0f, 2f);
        move_y = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
