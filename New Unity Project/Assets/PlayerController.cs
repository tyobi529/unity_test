using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody rigid;

    [SerializeField] Animator animator;

    


    // Start is called before the first frame update
    void Start()
    {
        //アニメーション
        animator.SetBool("isWalking", true);

    }

    // Update is called once per frame
    void Update()
    {
        //?N???b?N???_?b?V??
        if (Input.GetMouseButton(0))
        {
            rigid.AddForce(100f, 0f, 0f);

            //Debug.Log("aaa");
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddForce(1000, 1000f, 0f);

            animator.SetBool("isWalking", false);
            animator.SetBool("isFlying", true);
        }
    }


}
