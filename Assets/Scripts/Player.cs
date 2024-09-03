using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class Player : MonoBehaviour
{

    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
            anim.SetBool("Moving", true);
            anim.SetFloat("MoveX", rb.velocity.x);
            anim.SetFloat("MoveY", rb.velocity.y);
            Debug.Log(rb.velocity);
        }

        else
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("Moving", false);
        }

    }
}
