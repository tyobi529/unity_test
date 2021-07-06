using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] Rigidbody rigid;

    [SerializeField] Animator animator;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //?N???b?N???_?b?V??
        if (Input.GetMouseButton(0))
        {
            rigid.AddForce(50f, 0f, 0f);

            Debug.Log("aaa");
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddForce(1000f, 1000f, 0f);

            animator.SetBool("isFlying", true);
        }
    }


}
