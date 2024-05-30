using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform target;
    Vector3 targetPos;
    public Vector3 offsetPos;
    public float moveSpeed = 5;
    public float smooth = 0.2f;
    public string WallsTag;
    private Vector3 velocity = Vector3.zero;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MoveWithTarget();
    }
    void MoveWithTarget()
    {
        targetPos = target.transform.position + offsetPos;
        //transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime* smooth);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smooth);
    }

    private void Update()
    {
        HideWall();

    }

    private void HideWall()
    {

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var go = hit.collider.gameObject;

            if (go.tag == WallsTag)
            {
                go.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
