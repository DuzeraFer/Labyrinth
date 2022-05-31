using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    int actualScene;

    public Transform ball;
    Transform startPos;

    private void Start()
    {
        startPos = ball;
        actualScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void nextScene()
    {
        SceneManager.LoadScene(actualScene + 1);
    }

    public void restartScene()
    {
        SceneManager.LoadScene(actualScene);
    }
}
