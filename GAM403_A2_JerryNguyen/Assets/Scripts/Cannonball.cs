using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    public float speed;
    public float killTime;
    public Rigidbody rb;
    public GameObject spark;
    Collider col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
    public void GoFast()
    {
        rb.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        Destroy(gameObject, killTime);
    }
}
