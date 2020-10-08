using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool dragging = false;
    private float distance;
    RaycastHit hit;
    public static bool parent = true;
    public GameObject grabber;
    public GameObject leg, leg1, leg2, leg3, table;
    bool bool1 = true, bool2 = true, bool3 = true, bool4 = true, bool5 = true, bool6 = true, bool7 = true, bool8 = true,
        bool9 = true, bool10 = true, bool11 = true, bool12 = true, bool13 = true, bool14 = true, bool15 = true, bool16 = true;

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
        while(parent)
        {
            if (bool1 && leg.transform.position.x < 1.2f && 0.5f < leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
                parent = false;
                bool1 = false;
                break;
            }

            if (bool2 && leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
                parent = false;
                bool2 = false;
                break;
            }
            if (bool3 && leg.transform.position.x < 1.2f && 0.5f < transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
                parent = false;
                bool3 = false;
                break;
            }
            if (bool4 && leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
                parent = false;
                bool4 = false;
                break;
            }




            if (bool5 && leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool5 = false;
                break;
            }

            if (bool6 && leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool6 = false;
                break;
            }
            if (bool7 && leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool7 = false;
                break;
            }
            if (bool8 && leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool8 = false;
                break;
            }


            if (bool9 && leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool9 = false;
                break;
            }

            if (bool10 && leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool10 = false;
                break;
            }
            if (bool11 && leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool11 = false;
                break;
            }
            if (bool12 && leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool12 = false;
                break;
            }



            if (bool13 && leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool13 = false;
                break;

            }

            if (bool14 && leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool14 = false;
                break;

            }
            if (bool15 && leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool15 = false;
                break;

            }
            if (bool16 && leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool16 = false;
                break;
            }
            parent = false;
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
        }
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit) && hit.rigidbody && hit.transform.parent==null)
            {
                parent = false;
                Vector3 rayPoint = ray.GetPoint(distance);
                hit.transform.position = new Vector3(rayPoint.x, rayPoint.y, rayPoint.z);
                hit.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

}
