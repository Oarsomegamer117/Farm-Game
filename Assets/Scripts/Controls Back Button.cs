using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsBackButton : MonoBehaviour
{
    public void LoadSceneByName()//The function that loads a new scene.
    {
        SceneManager.LoadScene("Scenes/Start Menu");//Says what scene to load based on the name that its given.
    }
}
