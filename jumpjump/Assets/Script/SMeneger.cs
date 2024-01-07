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

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void BacktoHomePage()
    {
        SceneManager.LoadScene(0);
    }
}