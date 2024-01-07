using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public int levelNum;

    private void Update()
    {
        Invoke("LoadNextLevel", 2f);

    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(levelNum);
    }
}
