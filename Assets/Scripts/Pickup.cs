using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject pickupPrefab = null;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(pickupPrefab, transform.position, Quaternion.identity);

        // add another parameter(float) if you want delay
        Destroy(gameObject);

    }
}
