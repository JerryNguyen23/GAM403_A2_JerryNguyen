using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject cannonball;
    public Transform barrel;
    public float ballSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject cb = Instantiate(cannonball, barrel.position, barrel.rotation);
        Cannonball cbScript = cb.GetComponent<Cannonball>();
        cbScript.speed = ballSpeed;
        cbScript.GoFast();
    }
}
