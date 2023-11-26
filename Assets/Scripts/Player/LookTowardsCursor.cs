using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardsCursor : MonoBehaviour
{
    void Update()
    {
        //Make player look towards cursor
        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg -90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
