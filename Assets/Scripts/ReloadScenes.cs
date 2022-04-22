using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScenes : MonoBehaviour
{

    public void RestartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
}
