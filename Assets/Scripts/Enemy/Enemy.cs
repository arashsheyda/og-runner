using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Movement movement;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        // transform.LookAt(Vector3.back);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement.MoveCharacter(transform, Vector3.back, Time.fixedDeltaTime);
        // transform.LookAt(target);
    }
}
