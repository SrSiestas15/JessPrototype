using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private void Start()
    {
    }

    public void loadScene(string sceneName)
    {
        PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(sceneName);
    }

    public void lastScene() 
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastLevel"));
    }
}
