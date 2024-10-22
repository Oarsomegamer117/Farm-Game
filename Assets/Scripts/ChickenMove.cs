using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody2D rb; //Rigidbody for the chicken
    private float speed; //Variable to hold number for speed chicken will move
    private float timer; //To keep track of the amount of time its been
    private float waitime;//To keep track of the time spent waiting
    private bool waiting;//Boolean to check if the charcter is waiting
    private int waitnum;//Time to wait before moving again
    private int walktime;//Time for walking
    Animator anim;//Call the animator anim

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Making the rigidbody component = rb
        anim = GetComponent<Animator>();//Making the animator component = anim

        speed = 3;//Set the speed the chicken will move at to 3
        timer = 0;//Start the timer at 0
        waitime = 0;//Start the waitime timer at 0
        waiting = false;//Set the waiting boolean to flase
        waitnum= 0;//Set the waitnum to 0

        int num = Random.Range(1, 5);//Picks a random number between 1 and 4

        Vector2 direction;//To store the movement direction for the chicken

        if (num == 1)//If the random number picked is 1 move right
            direction = Vector2.right;
        else if (num == 2)//Else if the number picked is 2 move left
            direction = Vector2.left;
        else if (num == 3)//Else if the number picked is 3 move up
            direction = Vector2.up;
        else//If its not 1, 2, or 3 move down
            direction = Vector2.down;//changed from right?

        waitnum = Random.Range(2, 6);//Ranodmly select a number between 2 and 5 to wait.
 
        rb.velocity = direction * speed;//Move the chicken based on what was decided above
    }

    void Update()
    {
        timer += Time.deltaTime;//Have the timer count up 1 every second
        waitime += Time.deltaTime;//Have the waitime count up 1 every second

        if (waiting == false)//If the chicken is not moving
        {
            anim.SetBool("ChickenMoving", true);//Set the moving bool for the animator to true

            if (timer > 2)//If 2 seconds have passed
            {
                waiting = true;//Set waiting to true
                timer = 0;//Reset the timer back to 0
            }
        }

        if (waiting == true)//If waiting is true
        {
            rb.velocity = Vector2.zero;//Stop the chickens movement

            anim.SetBool("ChickenMoving", false);//Set the moving bool for the animator to false


            if (timer > waitnum)//When the timer is greater than the random number picked as the waitnum
            {
                int num = Random.Range(1, 5);//Pick a random number between 1 nd 4

                Vector2 direction;//Vector 2 to store the movement direction for the chicken

                if (num == 1)//If the number is 1
                {
                    direction = Vector2.right;//Make the direction to move in right
                    anim.SetFloat("X", 1);//Set the x value in the animator float to 1
                    anim.SetFloat("Y", 0);//Set the y value in the animator float to 0. Both of these combined mean the right animation will play
                  //  Debug.Log("right is now 1");//Print to the console that we should be going right
                }
              

                else if (num == 2)//If the number is 2
                {
                    direction = Vector2.left;//Make the direction to move in left
                    anim.SetFloat("X", -1);//Set the x value in the animator float to -1
                    anim.SetFloat("Y", 0);//Set the y value in the animator float to 0. Both of these combined mean that the left animation will play
                  //  Debug.Log("left is now -1");//Print to the console that we should be going left
                }
                

                else if (num == 3)//If the numver is 3
                {
                    direction = Vector2.up;//Make the direction to move in up
                    anim.SetFloat("Y", 1);//Set the y value in the animator float to 1
                    anim.SetFloat("X", 0);//Set the x value in the animator float to 0. Both of these combined mean that the up animation will play
                  //  Debug.Log("up is now 1");//Print to the console that we should be going up
                }
                   
                else//If the number isnt 1, 2, or 3
                {
                    direction = Vector2.down;//Make the direction to move in up. Changed from right
                    anim.SetFloat("Y", -1);//Set the y value in the animator float to -1
                    anim.SetFloat("X", 0);//Set the x value in the animator float to 0. Both of these combined mean that the down animation will play
                  //  Debug.Log("down is now -1");//Print to the console that we should be going down
                }
                   

                //move the character based on the above
                timer = 0;//Reset the timer to 0
                rb.velocity = direction * speed;//Move the chicken based on what was decided above
                waiting = false;//Set waiting to false
            }

      
            
        }



    }

}
