using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public string LevelToLoad;
    

    public void Load()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
    public static void Load(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
