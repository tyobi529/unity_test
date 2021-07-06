using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 firstCameraPos;
    private float difX;

    private float difY;

    [SerializeField] GameObject player;


    void Start()
    {
        firstCameraPos = this.gameObject.transform.position;
        difX = this.gameObject.transform.position.x - player.transform.position.x;

        difY = this.gameObject.transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = new Vector3(player.transform.position.x + difX, firstCameraPos.y, firstCameraPos.z);

        this.transform.position = new Vector3(player.transform.position.x + difX, player.transform.position.y + difY, firstCameraPos.z);
    }
}
