using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private int sceneIndexToLoad = 0; // Change to 0 for Scene 0

    public void LoadNewScene()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
        
    }

    public void StartGame()
    {
        sceneIndexToLoad = 1;
        LoadNewScene();
    }
    public void Instruction()
    {
        sceneIndexToLoad = 3;
        LoadNewScene();
    }
    public void Controls()
    {
        sceneIndexToLoad = 2;
        LoadNewScene();
    }
    public void BackBut()
    {
        sceneIndexToLoad = 0;
        LoadNewScene();
    }
}
