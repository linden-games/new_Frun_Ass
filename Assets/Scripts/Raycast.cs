using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool dragging = false;
    private float distance;
    RaycastHit hit;
    public static bool parent = true;
    public GameObject grabber;
    public GameObject leg, leg1, leg2, leg3, table;
    int a = 0;

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
        if (parent)
        {
            if (leg.transform.position.x < 1.2f && 0.5f < leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
            }

            if (leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
            }
            if (leg.transform.position.x < 1.2f && 0.5f < transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
            }
            if (leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
            }




            if (leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
            }

            if (leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
            }
            if (leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
            }
            if (leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
            }


            if (leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
            }

            if (leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
            }
            if (leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
            }
            if (leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
            }



            if (leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
            }

            if (leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
            }
            if (leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
            }
            if (leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
            }

        }

        if (Input.GetMouseButtonDown(0))
            {
                distance = Vector3.Distance(transform.position, Camera.main.transform.position);
                dragging = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                dragging = false;
                parent = true;
            a += 1;
            }

            if (dragging)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit) && hit.rigidbody)
                {
                parent = false;
                Vector3 rayPoint = ray.GetPoint(distance);
                hit.transform.position = new Vector3(rayPoint.x, rayPoint.y, rayPoint.z);
                hit.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            }
            if(a >= 4)
        {

        }
    }

}
