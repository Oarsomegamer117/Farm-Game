using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovementJoystick : MonoBehaviour
{
    public GameObject joystick;//Reference of the joystick gameobject
    public GameObject joystickBG;//Reference of the joystick background
    public Vector2 joystickVec;//Vector 2 to store the position of the joystick vector
    private Vector2 joystickTouchPos;//Vector 2 to store the position of the touch for the joystick
    private Vector2 joystickOriginalPos;//Vector 2 to store the original position of the joystick
    private float joystickRadius;//How far the joystick can move or the radius it can move in

    void Start()
    {
        joystickOriginalPos = joystickBG.transform.position;//Set the original position of the joystick to where the background is currently
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 1;//Get the radius that the joystick can move in based on the size of the joystick background.
    }

    public void PointerDown()//When the joystick is pressed/clicked
    {
        joystick.transform.position = Input.mousePosition;//Set the position of the joystick to the position the press/click was
        joystickBG.transform.position = Input.mousePosition;//Set the position of the joystick background to the position the press/click was
        joystickTouchPos = Input.mousePosition;//Store the touch position to where the press/click was
    }

    public void Drag(BaseEventData baseEventData)//When the joystick is dragged
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;//Change the base event data to PointerEventData meaning it can access pointer specific data
        Vector2 dragpos = pointerEventData.position;//Get the current drag position of the joystick
        joystickVec = (dragpos - joystickTouchPos).normalized;//Find the direction of the joystick movement

        float joystickDist = Vector2.Distance(dragpos, joystickTouchPos);//Find the distance between the drag position and the touch position

        if(joystickDist < joystickRadius)//If the distance dragged is within the radius allowed
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickDist;//Move the joystick to the drag position
        }

        else//If the distance dragged is greater that the radius allowed
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;//Move the joystick to the maximum radius
        }
    }

    public void PointerUp()//When you stop the click/press
    {
        joystickVec = Vector2.zero;//Reset the joystick vector to 0
        joystick.transform.position = joystickOriginalPos;//Move the joystick back to its original position
        joystickBG.transform.position = joystickOriginalPos;//Move the joystick background back to its original position
    }

}
