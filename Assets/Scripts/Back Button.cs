using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Scenes/Start Menu");
    }
    // This is what loads the new main menu when the back button is pressed
}
