using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    private Vector3 mOffset;



    private float mZCoord;


    public static bool screw = false;

    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // x 0.5 1.2 z -6.2 -6.7
    // z -6.1 -5.3 x 1.2 0.5

    private void OnMouseUp()
    {
        if(transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
        {
            transform.position = new Vector3(0.867f, 0.592f, -6.478f);
        }

        if (transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -6.2f && -6.7f < transform.position.z)
        {
            transform.position = new Vector3(-0.867f, 0.592f, -6.478f);
        }
        if (transform.position.x < 1.2f && 0.5f < transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
        {
            transform.position = new Vector3(0.867f, 0.592f, -5.714f);
            
        }
        if (transform.position.x > -1.2f && -0.5f > transform.position.x && transform.position.z < -5.3f && -6.1f < transform.position.z)
        {
            transform.position = new Vector3(-0.867f, 0.592f, -5.714f);
        }


    }
}
