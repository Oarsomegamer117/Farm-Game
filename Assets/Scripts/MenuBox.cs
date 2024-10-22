using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuBox : MonoBehaviour
{
    public GameObject popupBox;//Reference to the panel game object
    public GameObject MovementJoystick;//Reference to the Joystick game object

    public static int carrotNum;
    public static int moneyNum;

    public TextMeshProUGUI carrotsDisplayText;   //the text that is displayed for the carrots
    public TextMeshProUGUI moneyDisplayText;   //the text that is displayed for the money

    public void TogglePopup()//A function that will toggle the panel from being visible and invisible
    {
        popupBox.SetActive(!popupBox.activeSelf);//Toggles the active state of the panel and all of its children, makes them visible or invisible
        MovementJoystick.SetActive(!MovementJoystick.activeSelf);//Toggles the active state of the joystick, makes them invisible when the menu panel opens so you can't move around when interacting with the menu.

        carrotsDisplayText.text = "Carrots - " + carrotNum;
    }

    public void SellCarrot()
    {
        moneyNum = carrotNum * 2;

        carrotsDisplayText.text = "Carrots - " + 0;

        moneyDisplayText.text = "Money - $" + moneyNum;
    }
}
