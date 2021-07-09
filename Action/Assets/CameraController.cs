using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CameraController : MonoBehaviour
{
    private Vector3 firstPos;

    //[SerializeField] GameObject player;

    float preX;
    
    // Start is called before the first frame update
    void Start()
    {
        firstPos = transform.position;

        //preX = firstPos.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCameraPos(float x)
    {
        //transform.position = new Vector3(x, firstPos.y, firstPos.z);

        if (Mathf.Abs(transform.position.x - x) > 2f)
        {
            transform.DOMoveX(x, 0.4f).SetDelay(0.1f);
        }

        //preX = x;
    }
}
