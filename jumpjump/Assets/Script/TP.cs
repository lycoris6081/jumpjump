using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public Transform targetPosition; // 目标位置
    public float moveSpeed = 2f; // 移动速度
    public GameObject player;

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
            Debug.Log("player");
                Invoke("Move", 0.5f);
            }
        }
    void Move()
    {
        player.transform.position = targetPosition.position;
    }
}

    
