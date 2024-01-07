using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassDetect : MonoBehaviour
{
    public int levelNum;
    public Transform targetPosition; // 目标位置
    public float moveSpeed = 2f; // 移动速度
    public GameObject camera;
    private bool pass = false;
    public GameObject objectToClose;

    void Update()
    {
        if (pass)
        {
            Invoke("Move", 0.2f);
        }
    }

    void Move()
    {
        objectToClose.SetActive(false);
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("玩家触发了碰撞!");
            pass = true;
            Invoke("LoadNextLevel", 2f);
        }
    }
      
    void LoadNextLevel()
    {
        SceneManager.LoadScene(levelNum);
    }
}