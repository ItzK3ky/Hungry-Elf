using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _movementAmount;
    public int id;

    private Vector3 _upPosition;
    private Vector3 _downPosition;

    private bool _isUp;


    void Start()
    {
        _upPosition = transform.position;
        _downPosition = transform.position;
        _upPosition.y += _movementAmount;
        _downPosition.y -= _movementAmount;
    }

    void Update()
    {
        if (_isUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, _downPosition, _moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _upPosition, _moveSpeed * Time.fixedDeltaTime);
        }

        if(transform.position == _upPosition)
        {
            _isUp = true;
        }
        else if(transform.position == _downPosition)
        {
            _isUp = false;
        }
    }
}
