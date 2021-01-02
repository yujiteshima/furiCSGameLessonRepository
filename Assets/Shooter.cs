using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    float move = 0.05f;
    // Start is called before the first frame update
    public GameObject[] prefabs = new GameObject[4];

    int curvege = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += move;
        if( pos.x < -2.5f )
        {
            move = 0.05f;
        }
        if ( pos.x > 2.5f)
        {
            move = -0.05f;
        }
        transform.position = pos;

        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(prefabs[curvege], pos, Quaternion.identity);
            curvege++;

            curvege %= 4;
        }
    }

    
}
