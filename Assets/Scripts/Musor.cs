using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musor : MonoBehaviour
{
    private int angel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }
    
    void Update()
    {
        angel++;
        transform.rotation = Quaternion.Euler (0,0,angel );
    }
    
}
