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

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void BacktoHomePage()
    {
        SceneManager.LoadScene(0);
    }
}