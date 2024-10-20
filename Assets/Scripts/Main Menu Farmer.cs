using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFarmer : MonoBehaviour
{
    float speed;//Variable to hold speed the farmer will travel at.
    Rigidbody2D rb;//Calling the rigidbody rb


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Making rb the rigidbody component
        speed = 4.0f;//Setting the speed number to 4
        rb.velocity = new Vector2(speed, 0);//Making the farmer automatically move across the screen when the game is loaded.
    }
}




//pick a direction out of up, down, left, right

//get a random number between 1 - 4


//wait 2 seconds

//go back to start

//Coroutine (Wait x time) does it. 
//Stopcouritine
