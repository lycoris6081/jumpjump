using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

//�o�{���b�޲z�C�������W�����s
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