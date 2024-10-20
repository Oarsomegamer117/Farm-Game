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
        StartCoroutine(TypeLine()); //This will start the type line function to add the text to the screen.

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
                StopAllCoroutines(); //stops the typing of the previous line
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

    IEnumerator TypeLine()
    {
        //this types each character 1 by 1 so the text looks like it's being typed as the conversation happens.
        foreach (char c in lines[index].ToCharArray()) //This takes the enire string and breaks it down into a character array with each character as an individual.
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed); //this sets the speed at which the characters will be typed at. 
                                                        //I define this in the inspector in Unity.
        }
    }
    
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++; //adds an int of 1 each time the next line is called.
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine()); //starts the coroutine to type the next line out.
        }
    }
}
