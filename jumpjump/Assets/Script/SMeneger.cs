using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

//這程式在管理遊戲介面上的按鈕
public class SMeneger : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip ButtonSound;
    public int levelNum;
    public int NextNum;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void BacktoHomePage()
    {
        SceneManager.LoadScene(levelNum);
    }

    public void PLAY()
    {
        SceneManager.LoadScene(NextNum);
    }
}