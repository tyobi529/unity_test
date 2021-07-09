using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CameraController cameraController;

    [SerializeField] GameObject lightningObj;
    [SerializeField] GameObject lightningStart;
    [SerializeField] GameObject lightningEnd;

    //[SerializeField] GameObject laser;
    [SerializeField] LineRenderer laser;
    
    private Vector3 startPos;
    private Vector3 endPos;

    private bool isErase = true;
    private float eraseTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -40f, 0);

        //startPos = transform.position;

        //lightningObj.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isErase)
        {
            eraseTime += Time.deltaTime;

            if (eraseTime > 0.2f)
            {
                eraseTime = 0f;
                isErase = true;

                laser.enabled = false;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //float x = Mathf.RoundToInt(hit.point.x);
                //float z = Mathf.RoundToInt(hit.point.z);
                //Debug.Log(x);
                //Debug.Log(z);

                Debug.Log(hit.point.x);
                Debug.Log(hit.point.y);
                Debug.Log(hit.point.z);


                float x = hit.point.x;
                float y = hit.point.y;

                //移動元
                startPos = transform.position;
                //補正
                startPos = new Vector3(startPos.x, startPos.y - 1.5f);
                //移動先
                endPos = new Vector3(x, y, 0);
                //補正
                endPos = new Vector3(endPos.x, endPos.y - 1.5f);

                //雷
                //lightningStart.transform.position = startPos;
                //lightningEnd.transform.position = endPos;

                var positions = new Vector3[]
                {
                    startPos,
                    endPos
                };

                laser.enabled = true;
                laser.SetPositions(positions);


                //速度リセット
                transform.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f);

                //移動
                transform.position = new Vector3(x, y, 0);


                isErase = false;

                //lightningObj.SetActive(true);



                //lightningStart.transform.position = new Vector3()

                //カメラ移動
                cameraController.ChangeCameraPos(x);
                
            }
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (transform.parent == null && col.gameObject.tag == "Floor")
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }

        //if (transform.parent == null && col.gameObject.name == "Floor")
        //{
        //    var emptyObject = new GameObject();
        //    emptyObject.transform.parent = col.gameObject.transform;
        //    transform.parent = emptyObject.transform;
        //}
    }

    void OnCollisionExit(Collision col)
    {
        if (transform.parent != null && col.gameObject.tag == "Floor")
        {
            transform.parent = null;
        }

        //if (transform.parent != null && col.gameObject.name == "Floor")
        //{
        //    transform.parent = null;
        //}
    }


}
