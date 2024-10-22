using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotdestroyer : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        MenuBox.carrotNum = MenuBox.carrotNum + 1;

        Debug.Log("carrotNum up 1");

        Destroy(gameObject);
    }

}
    
