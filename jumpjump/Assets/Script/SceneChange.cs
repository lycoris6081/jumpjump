using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int levelNum;
    public int t;

    void Update()
    {
        Invoke("S", t);  
    }
    void S()
    {
        SceneManager.LoadScene(levelNum);
    }
}
