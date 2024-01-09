using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float floatSpeed = 1f;  
    public float floatHeight = 1f; 

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        transform.position = new Vector3(initialPosition.x, initialPosition.y + yOffset, initialPosition.z);
    }
}
