﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject cannonball;
    public Transform barrel;
    public float ballSpeed;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Go");
        }
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            Time.timeScale = 1;
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
