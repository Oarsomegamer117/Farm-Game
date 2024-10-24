using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuBox : MonoBehaviour
{
    public GameObject popupBox;//Reference to the panel game object
    public GameObject MovementJoystick;//Reference to the Joystick game object

    public static int carrotNum; //Reference to the carrot number
    public static int moneyNum; //Reference to the money number
    public int carrotMult; //Reference to the carrot multiplyer
    public float timeDecreaser; //Reference to the time decreaser

    public TextMeshProUGUI carrotsDisplayText;   //the text that is displayed for the carrots
    public TextMeshProUGUI moneyDisplayText;   //the text that is displayed for the money

    void Start()
    {
        carrotMult = 2;//Set the carrot multiplyer to 2

        timeDecreaser = 0.1f;//Set the time decreaser to 0.1
    }
    public void TogglePopup()//A function that will toggle the panel from being visible and invisible
    {
        popupBox.SetActive(!popupBox.activeSelf);//Toggles the active state of the panel and all of its children, makes them visible or invisible
        MovementJoystick.SetActive(!MovementJoystick.activeSelf);//Toggles the active state of the joystick, makes them invisible when the menu panel opens so you can't move around when interacting with the menu.

        carrotsDisplayText.text = "Carrots - " + carrotNum;//Display the text in the text mesh pro Carrots - the carrot number.
    }

    public void SellCarrot()//Function called when selling carrots
    {
        
            moneyNum = carrotNum * carrotMult; //set the money number to the carrot number multiplied by the carrot multiplyer

            carrotsDisplayText.text = "Carrots - " + 0; //Set the carrot text mesh pro to Carrot - 0

            moneyDisplayText.text = "Money - $" + moneyNum;//Set the money text mesh pro to Money - $ and the money number that is picked from the carrot number multiplyed by the carrot multiplyer

            carrotNum = 0; //Set the carrot number back to 0
       

    }

    public void Upgrade()//Function called when upgrading
    {
        if (moneyNum >= 10)//If the money number is greater than or equal to 10. This is used so player don't get negative money.
        {
            moneyNum = moneyNum - 10;//Lower the money number by 10

            moneyDisplayText.text = "Money - $" + moneyNum;//Set the money text to Money - $ and the money number

            carrotMult = carrotMult + 1; //Add 1 to the carrot multiplyer

            Spawn.upgradeNum = Spawn.upgradeNum - timeDecreaser;//Take away the time decreaser from the upgrade number in the Spawn script. (Make the carrots spawn faster)
        }
    }


}
