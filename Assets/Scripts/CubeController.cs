using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        } 
        else if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
    }

    private void Move(Vector3 direction)
    {
        var pivotPoint = (direction / 2f) + (Vector3.down / 2f);
        
        var pos = transform.position;

        pos = pos + direction * Time.deltaTime;
        transform.position = pos;
    }
}
