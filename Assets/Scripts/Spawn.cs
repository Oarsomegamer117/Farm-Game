using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    float SpawnTimer; //reference to the timer which will control the rate at which carrots spawn
    public GameObject Carrot; //reference to the carrot game object

   

    public static float upgradeNum;//reference that other scripts can access to the upgrade number

    // Start is called before the first frame update
    void Start()
    {
        SpawnTimer = 0;//Set the timer for spawwning carrots to 0 at the start of the game;
        upgradeNum = 3.0f;//Set the upgrade number to 3 at the start of the game;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime; //Have the timer count up 1 every second


        if (SpawnTimer > upgradeNum) //if the number for the timer is greater than the number of the upgrade number
        {
            int xPos = Random.Range(29, 42); //pick a random integer between 29 and 41 that's called xPos
            int yPos = Random.Range(-4, -26); //pick a random integer between -4 and -25 that's called yPos

            Vector2 pos = new Vector2(xPos, yPos); //Create a new vector 2 that is made up of these random integers and call it pos

            Instantiate(Carrot, pos, Quaternion.identity); //Instantiate/spawn a carrot gameobject at the vector 2 called pos

            SpawnTimer = 0;//Reset the timer back to 0
        }
    }



    //Random x position
    //Random y position
    //Use timer to know when to spawn each carrot.
    //Make vector to instantiate at that position.
    //Reset timer after each instantiation
}
