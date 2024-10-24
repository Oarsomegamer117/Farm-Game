using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotdestroyer : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)//Function called when the carrot has a collision.
    {

        MenuBox.carrotNum = MenuBox.carrotNum + 1; //Add 1 to the carrot number in the Menu box script

        Debug.Log("carrotNum up 1"); //Print to the console that the carrot number has gone up by 1

        Destroy(gameObject); //Destroy the carrot game object
    }

}
    
