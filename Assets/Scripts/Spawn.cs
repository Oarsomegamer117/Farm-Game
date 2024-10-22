using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    float SpawnTimer;
    int xPos;
    int yPos;
    public GameObject Carrot;

    public int carrotNum;

    // Start is called before the first frame update
    void Start()
    {
        SpawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;


        if (SpawnTimer > 3)
        {
            int xPos = Random.Range(29, 42);
            int yPos = Random.Range(-4, -26);

            Vector2 pos = new Vector2(xPos, yPos);

            Instantiate(Carrot, pos, Quaternion.identity);

            SpawnTimer = 0;
        }
    }



    //Random x position
    //Random y position
    //Make co oridinate or vector to instantiate at that position.
    //Use timer to know when to spawn each carrot.
    //Reset timer after each instantiation
}
