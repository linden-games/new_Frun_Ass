using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool dragging = false;
    private float distance;
    RaycastHit hit;

    public Rigidbody Ball;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }


    void Update()
    {

            if (Input.GetMouseButtonDown(0))
            {
                distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                dragging = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                dragging = false;
            hit.transform.parent = null;
            }

            if (dragging)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit) && hit.rigidbody)
                {
                hit.transform.position = transform.position;
                hit.transform.rotation = Quaternion.Euler(0, 0, 0);
                hit.transform.parent = transform;
                }
                Vector3 rayPoint = ray.GetPoint(distance);
                transform.position = new Vector3(rayPoint.x, rayPoint.y + 1, rayPoint.z);
            }
    }

}
