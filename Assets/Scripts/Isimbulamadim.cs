using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isimbulamadim : MonoBehaviour
{
    public GameObject leg, leg1, leg2, leg3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Raycast.parent)
        {
            if (leg.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
            }

            if (leg.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
            }
            if (leg.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -5.714f);

            }
            if (leg.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
            }




            if (leg1.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
            }

            if (leg1.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
            }
            if (leg1.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -5.714f);

            }
            if (leg1.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
            }


            if (leg2.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
            }

            if (leg2.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
            }
            if (leg2.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -5.714f);

            }
            if (leg2.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
            }



            if (leg3.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
            }

            if (leg3.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
            }
            if (leg3.transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -5.714f);

            }
            if (leg3.transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
            }

        }
    }
}
