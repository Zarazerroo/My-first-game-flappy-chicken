using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class StartGame : MonoBehaviour
{
    public string sceneToLoad; // Set the scene name you want to load in the Inspector

    public void LoadScene()
    {
        SceneManager.LoadScene(0);

    }
}
