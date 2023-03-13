using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public partial class CubeController : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 5f;
    private Vector3 _axis;
    private Vector3 _pivotPoint;
    private bool _isMoving;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    public void Move(Vector3 direction)
    {
        var isGrounded = CheckIsGrounded();
        if (!isGrounded)
        {
            return;
        }
        
        var verticalComponent = Vector3.down;
        var hasWall = HasWallInDirection(direction);
        if (hasWall)
        {
            verticalComponent = Vector3.up;
        }
        
        _axis = Vector3.Cross(Vector3.up, direction);
        _pivotPoint = (direction / 2f) + (verticalComponent / 2f) + transform.position;

        StartCoroutine(Roll(_pivotPoint, _axis));
    }

    

    private IEnumerator Roll(Vector3 pivot, Vector3 axis)
    {
        _isMoving = true;
        _rigidbody.isKinematic = true;

        for (int i = 0; i < 90 / _rollSpeed; i++)
        {
            transform.RotateAround(pivot, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }

        _rigidbody.isKinematic = false;
        _isMoving = false;

        SnapPositionToInteger();
    }

    private void SnapPositionToInteger()
    {
        var pos = transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.z = Mathf.Round(pos.z);

        transform.position = pos;
    }
}
