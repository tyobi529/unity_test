using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    [SerializeField] GameObject floorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject a = Instantiate(floorPrefab);
            float y = Random.Range(-5f, 5f);

            a.transform.position = new Vector3(i * 5, y, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
