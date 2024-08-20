using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody2D rb;
    private float speed;
    private float timer;
    private float waitime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 3;
        timer = 0;
        waitime = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            int num = Random.Range(1, 5);

            Vector2 direction;

            if (num == 1)
                direction = Vector2.right;
            else if (num == 2)
                direction = Vector2.left;
            else if (num == 3)
                direction = Vector2.up;
            else
                direction = Vector2.right;

            //move the character based on the above
            rb.velocity = direction * speed;
            timer = 0;
          
        }
         if (waitime > int num = Random.Range(1, 5))

        //pick a direction out of up, down, left, right

        //get a random number between 1 - 4
        

        //wait 2 seconds

        //go back to start
    }
}
