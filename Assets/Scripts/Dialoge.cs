using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Dialoge : MonoBehaviour
{

    public TextMeshProUGUI textComponent;   //the text that is displayed
    public string[] lines;  //the array that will hold each individual line
    public float textSpeed; //the speed that I will set for the characters to be typed at
    public Sprite[] dialogueIcons; //The array to hold the icons for who's speaking
    public Image characterIcon; //The image of the icon that will be displayed for each different line.

    public int index; //gives a number to the stage of the dialoge I am up to.



    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;//Making sure no text is currently displayed.

        index = 0;//Start the dialogue from the very start.

    } 
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)) //when the sreen is pressed or mouse is clicked
        {
            if(textComponent.text == lines[index]) //if the line has finished typing and the screen is clicked/mouse button down it goes to the next line.
            {
                NextLine(); //goes to the next line function
            }
            else
            {
                textComponent.text = lines[index]; //when the line hasn't finished typing and the screen is clicked change the line and stop the coroutine for writing the previous line.
            }
        }

        if(index != 0)
        {
            if (index < 6)
            {
                characterIcon.gameObject.SetActive(true); //if the index is correct the image will appear.
                characterIcon.sprite = dialogueIcons[index]; //if the index is not 0 and less than 6 the icon will appear and every frame the icon that will be put on the screen is chosen by the index number.
            }
        }
    }

    
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++; //adds an int of 1 each time the next line is called.
            textComponent.text = string.Empty;//This makes the text dissapear before the next line is put up on the screen.
        }
    }
}
