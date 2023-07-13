using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotatngFP : MonoBehaviour
{
    public GameObject target;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookDir = (Vector2)target.transform.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
