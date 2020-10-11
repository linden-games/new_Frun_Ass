using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEditorInternal;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool dragging = false;
    private float distance;
    RaycastHit hit;
    public static bool parent = true;
    public GameObject screw, screw1, screw2, screw3;
    public GameObject leg, leg1, leg2, leg3, table;
    #region Bool variables
    bool bool1 = true, bool2 = true, bool3 = true, bool4 = true, bool5 = true, bool6 = true, bool7 = true, bool8 = true,
        bool9 = true, bool10 = true, bool11 = true, bool12 = true, bool13 = true, bool14 = true, bool15 = true, bool16 = true;
    public bool attach = false, attach1 = false, attach2 = false, attach3 = false, test = false;
    #endregion
    readonly List<GameObject> legs = new List<GameObject>();
    public Animator cam;
    public Animator chivi, chivi1, chivi2, chivi3;
    public Animation screwanim, screwanim1, screwanim2, screwanim3;
    public int a = 0;
    public ParticleSystem screwdust, screwdust1, screwdust2, screwdust3;
    public ParticleSystem dust, dust1, dust2, dust3;
    // Use this for initialization
    void Start()
    {
        legs.Add(leg);
        legs.Add(leg1);
        legs.Add(leg2);
        legs.Add(leg3);
        screwdust.Stop();
        screwdust1.Stop();
        screwdust2.Stop();
        screwdust3.Stop();
        dust.Stop();
        dust1.Stop();
        dust2.Stop();
        dust3.Stop();

    }
    void Update()
    {
        while (parent)
        {
            if (bool1 && leg.transform.position.x < 1.2f && 0.5f < leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
                parent = false;
                bool1 = false;
                dust.Play();
                break;
            }

            if (bool2 && leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -6.2f && -6.7f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg.transform.parent = table.transform;
                parent = false;
                bool2 = false;
                dust3.Play();
                break;
            }
            if (bool3 && leg.transform.position.x < 1.2f && 0.5f < leg.transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
                parent = false;
                bool3 = false;
                dust1.Play();
                break;
            }
            if (bool4 && leg.transform.position.x > -1.2f && -0.5f > leg.transform.position.x && leg.transform.position.z < -5.3f && -6.1f < leg.transform.position.z)
            {
                leg.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg.transform.parent = table.transform;
                parent = false;
                bool4 = false;
                dust2.Play();
                break;
            }


            if (bool5 && leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool5 = false;
                dust.Play();
                break;
            }

            if (bool6 && leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -6.2f && -6.7f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool6 = false;
                dust3.Play();
                break;
            }
            if (bool7 && leg1.transform.position.x < 1.2f && 0.5f < leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool7 = false;
                dust1.Play();
                break;
            }
            if (bool8 && leg1.transform.position.x > -1.2f && -0.5f > leg1.transform.position.x && leg1.transform.position.z < -5.3f && -6.1f < leg1.transform.position.z)
            {
                leg1.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg1.transform.parent = table.transform;
                parent = false;
                bool8 = false;
                dust2.Play();
                break;
            }


            if (bool9 && leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool9 = false;
                dust.Play();
                break;
            }

            if (bool10 && leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -6.2f && -6.7f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool10 = false;
                dust3.Play();
                break;
            }
            if (bool11 && leg2.transform.position.x < 1.2f && 0.5f < leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool11 = false;
                dust1.Play();
                break;
            }
            if (bool12 && leg2.transform.position.x > -1.2f && -0.5f > leg2.transform.position.x && leg2.transform.position.z < -5.3f && -6.1f < leg2.transform.position.z)
            {
                leg2.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg2.transform.parent = table.transform;
                parent = false;
                bool12 = false;
                dust2.Play();
                break;
            }



            if (bool13 && leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool13 = false;
                dust.Play();
                break;

            }

            if (bool14 && leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -6.2f && -6.7f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -6.478f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool14 = false;
                dust3.Play();
                break;

            }
            if (bool15 && leg3.transform.position.x < 1.2f && 0.5f < leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool15 = false;
                dust1.Play();
                break;

            }
            if (bool16 && leg3.transform.position.x > -1.2f && -0.5f > leg3.transform.position.x && leg3.transform.position.z < -5.3f && -6.1f < leg3.transform.position.z)
            {
                leg3.transform.position = new Vector3(-0.867f, -0.408f, -5.714f);
                leg3.transform.parent = table.transform;
                parent = false;
                bool16 = false;
                dust2.Play();
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
            foreach (GameObject leg in legs)
            {
                leg.layer = LayerMask.NameToLayer("Default");
            }
        }
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.rigidbody && hit.transform.parent == null)
            {
                parent = false;
                Vector3 rayPoint = ray.GetPoint(distance);
                hit.transform.position = new Vector3(rayPoint.x, rayPoint.y, rayPoint.z);
                hit.transform.rotation = Quaternion.Euler(0, 0, 0);
                foreach (GameObject leg in legs)
                {
                    if (leg.transform != hit.transform)
                    {
                        leg.layer = LayerMask.NameToLayer("Ignore Raycast");
                    }
                }
            }
            if(Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "Chivi")
            {
                if (!attach)
                {
                    chivi.enabled = true;
                    StartCoroutine(Chivile());
                }
                if(a == 1)
                {
                    chivi1.enabled = true;
                    if (!screwanim.isPlaying && test)
                    {
                        StartCoroutine(Chivile1());
                    }
                }
                if(a == 2)
                {
                    chivi2.enabled = true;
                    if (!screwanim1.isPlaying)
                    {
                        StartCoroutine(Chivile2());
                    }
                }
                if (a == 3)
                {
                    chivi3.enabled = true;
                    if (!screwanim2.isPlaying)
                    {
                        StartCoroutine(Chivile3());
                    }
                }
                if(chivi1.enabled)
                {
                    test = true;
                }
            }
        }
        if (table.transform.childCount >= 4)
        {
            if (!attach)
            {
                cam.PlayInFixedTime("Camera");
            }
        }

    }
    IEnumerator Chivile()
    {
        chivi.Play("Chivi");
        screwdust.Play();
        yield return new WaitForSeconds(0.75f);
        attach = true;
        a = 1;
        cam.SetTrigger("newCam");
    }

    IEnumerator Chivile1()
    {
        chivi1.Play("Chivi1");
        screwdust1.Play();
        yield return new WaitForSeconds(0.75f);
        attach1 = true;
        a = 2;
        cam.SetTrigger("newCam1");
    }
    IEnumerator Chivile2()
    {
        chivi2.Play("Chivi2");
        screwdust2.Play();
        yield return new WaitForSeconds(0.75f);
        attach2 = true;
        a = 3;
        cam.SetTrigger("newCam2");
    }
    IEnumerator Chivile3()
    {
        chivi3.Play("Chivi3");
        screwdust3.Play();
        yield return new WaitForSeconds(0.75f);
        attach3 = true;
    }
}
