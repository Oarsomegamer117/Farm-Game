using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBox : MonoBehaviour
{
    public GameObject popupBox;//Reference to the panel game object
    public GameObject MovementJoystick;//Reference to the Joystick game object

    public void TogglePopup()//A function that will toggle the panel from being visible and invisible
    {
        popupBox.SetActive(!popupBox.activeSelf);//Toggles the active state of the panel and all of its children, makes them visible or invisible
        MovementJoystick.SetActive(!MovementJoystick.activeSelf);//Toggles the active state of the joystick, makes them invisible when the menu panel opens so you can't move around when interacting with the menu.
    }
}
