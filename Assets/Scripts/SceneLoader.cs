using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string sceneName;


    public void Load()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
