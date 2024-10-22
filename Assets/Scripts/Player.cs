using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;
using TMPro;

public class Player : MonoBehaviour
{

    public MovementJoystick movementJoystick;//Reference to the Joystick
    public float playerSpeed;//Variable to hold the speed the farmer will travel at
    private Rigidbody2D rb;//Calling the rigidbody rb
    Animator anim;//Calling the animator anim

    public bool talking;//A boolean to see if the farmer is talking

    public TMP_Text carrotsDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Making rb the rigidbody component
        anim = GetComponent<Animator>();//Making anim the animator component
        talking = false;//Setting the talking boolean to false
    }

    // Update is called once per frame
    void FixedUpdate()//Update function that is called once every frame, used for physics related updates
    {
        if(movementJoystick.joystickVec.y != 0)//Check if there is any vertical movement from the joystick
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);//Set the velocity of the rigidbody based on the joystick input multiplied by the pre-determined player speed
            anim.SetBool("Moving", true);//Set the moving boolean from the animator to true
            anim.SetFloat("MoveX", rb.velocity.x);//Make the MoveX float in the animator = the x velocity
            anim.SetFloat("MoveY", rb.velocity.y);//Make the MoveY float in the animator = the y velocity
           // Debug.Log(rb.velocity);//Print the velocity of the player to the console
        }

        else//If there is no vertical movement from the joystick
        {
            rb.velocity = Vector2.zero;//Set the speed of the player to 0
            anim.SetBool("Moving", false);//Set the moving bool for the animator to flase
        }
      
    }

    

    private void OnTriggerEnter2D(Collider2D collision)//When the player collides with a trigger collider
    {
        talking = true;//Set the talking bool to true
    }
}
