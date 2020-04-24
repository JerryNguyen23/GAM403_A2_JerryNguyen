using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points;
    private Score score;
    Collider col;
    void Start()
    {
        col = GetComponent<Collider>();
        score = GameObject.FindObjectOfType<Score>();
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        score.AddScore(points);
        Destroy(gameObject);
    }
}
