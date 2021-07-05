using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //クリックでダッシュ
        if (Input.GetMouseButton(0))
        {
            rigid.AddForce(10f, 0f, 0f);

            Debug.Log("aaa");
        }
    }


}
