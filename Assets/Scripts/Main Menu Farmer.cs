using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFarmer : MonoBehaviour
{
    float speed;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 4.0f;
        rb.velocity = new Vector2(speed, 0);
    }


}