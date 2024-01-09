using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float angle = 15;
    float speed = 5;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        // Rotation

        // Up Vector
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.AngleAxis(-angle * Time.deltaTime, Vector3.up);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.up);
        }

        // Right Vector
        if (Input.GetKey(KeyCode.T))
        {
            transform.rotation *= Quaternion.AngleAxis(-angle * Time.deltaTime, Vector3.right);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            transform.rotation *= Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.right);
        }

        // Forward Vector
        if (Input.GetKey(KeyCode.Z))
        {
            transform.rotation *= Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.forward);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.rotation *= Quaternion.AngleAxis(-angle * Time.deltaTime, Vector3.forward);
        }
    }
}

