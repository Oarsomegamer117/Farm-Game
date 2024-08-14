using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlsbuttonstartmenu : MonoBehaviour
{
    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Scenes/Controls Screen");
    }
    // This is what loads the new scene when the controls button is pressed.
}
