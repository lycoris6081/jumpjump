using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 targetPosition;
    public float moveSpeed = 2f;

    private bool isMoving = false;
    private float journeyTime;
    private Vector3 startPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    StartSmoothMovement();
                }
            }
        }

        if (isMoving)
        {
            MoveObjectSmoothly();
        }
    }

    void StartSmoothMovement()
    {
        isMoving = true;
        journeyTime = 0f;
        startPosition = targetObject.position;
    }

    void MoveObjectSmoothly()
    {
        journeyTime += Time.deltaTime * moveSpeed;

        if (journeyTime < 1f)
        {
            // 使用 Lerp 插值平滑移动
            targetObject.position = Vector3.Lerp(startPosition, targetPosition, journeyTime);
        }
        else
        {
            // 移动完成后停止
            targetObject.position = targetPosition;
            isMoving = false;
        }
    }
}
