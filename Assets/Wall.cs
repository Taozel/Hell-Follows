using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private MeshRenderer renderer;
    private bool isCorutineStarted = false; 

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (renderer != null && !renderer.enabled)
        {
            if(!isCorutineStarted)
                StartCoroutine(EnableWall());
        }
    }



    private IEnumerator EnableWall()
    {
        isCorutineStarted = true;
        yield return new WaitForSeconds(10);
        renderer.enabled = true;
        isCorutineStarted = false;
    }
}
