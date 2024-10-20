using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public void LoadSceneByName()//The function that loads a new scene.
    {
        SceneManager.LoadScene("Scenes/Main Level");//Says what scene to load based on the name that its given.
    }
}
