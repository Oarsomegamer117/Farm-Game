using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody2D rb;
    private float speed;
    private float timer;
    private float waitime;
    private bool waiting;
    private int waitnum;
    private int walktime;
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        speed = 3;
        timer = 0;
        waitime = 0;
        waiting = false;
        waitnum= 0;

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

        waitnum = Random.Range(2, 6);
        //move the character based on the above
        rb.velocity = direction * speed;
    }

    void Update()
    {
        timer += Time.deltaTime;
        waitime += Time.deltaTime;

        if (waiting == false)
        {
            if (timer > 2)
            {
                waiting = true;
                timer = 0;
            }
        }

        if (waiting == true)
        {
            rb.velocity = Vector2.zero;
            
         
            if (timer > waitnum)
            {
                int num = Random.Range(1, 5);

                Vector2 direction;

                if (num == 1)
                {
                    direction = Vector2.right;
                    anim.SetFloat("X", 1);
                    anim.SetFloat("Y", 0);
                    Debug.Log("right is now 1");
                }
              

                else if (num == 2)
                {
                    direction = Vector2.left;
                    anim.SetFloat("X", -1);
                    anim.SetFloat("Y", 0);
                    Debug.Log("left is now -1");
                }
                

                else if (num == 3)
                {
                    direction = Vector2.up;
                    anim.SetFloat("Y", 1);
                    anim.SetFloat("X", 0);
                    Debug.Log("up is now 1");
                }
                   
                else
                {
                    direction = Vector2.right;
                    anim.SetFloat("Y", -1);
                    anim.SetFloat("X", 0);
                    Debug.Log("down is now -1");
                }
                   

                //move the character based on the above
                timer = 0;
                rb.velocity = direction * speed;
                waiting = false;
            }

      
            
        }




        //pick a direction out of up, down, left, right

        //get a random number between 1 - 4
        

        //wait 2 seconds

        //go back to start

        //Coroutine (Wait x time) does it. 
        //Stopcouritine
    }

}
