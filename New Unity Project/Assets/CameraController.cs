using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Vector3 firstCameraPos;
    [SerializeField] Vector3 firstCameraRot;

    [SerializeField] Vector3 nextCameraPos;
    [SerializeField] Vector3 nextCameraRot;

    //private Vector3 firstCameraPos;

    private float difX;
    private float difY;

    private float nextDifX;
    private float nextDifY;

    [SerializeField] GameObject player;

    bool isEnd = false;

    float speed;

    void Start()
    {
        //firstCameraPos = this.gameObject.transform.position;
        
        

        transform.position = firstCameraPos;
        transform.rotation = Quaternion.Euler(firstCameraRot);

        difX = this.gameObject.transform.position.x - player.transform.position.x;
        difY = this.gameObject.transform.position.y - player.transform.position.y;

        nextDifX = nextCameraPos.x - player.transform.position.x;
        nextDifY = nextCameraPos.y - player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(player.transform.position.x + difX, firstCameraPos.y, firstCameraPos.z);

        if (!isEnd)
        {
            this.transform.position = new Vector3(player.transform.position.x + difX, player.transform.position.y + difY, firstCameraPos.z);

            //Debug.Log(player.transform.position.x);

            if (player.transform.position.x > 100f)
            {
                isEnd = true;

                //保存
                speed = player.GetComponent<Rigidbody>().velocity.x;

                //速度一定
                player.GetComponent<Rigidbody>().velocity = new Vector3(10f, 0f);
            }

        }
        else
        {
            Debug.Log("change");

            transform.rotation = Quaternion.Euler(nextCameraRot);

            this.transform.position = new Vector3(player.transform.position.x + nextDifX, player.transform.position.y + nextDifY, nextCameraPos.z);

            //transform.position = nextCameraPos;
            //transform.rotation = Quaternion.Euler(nextCameraRot);



            
        }
        


    }
}
