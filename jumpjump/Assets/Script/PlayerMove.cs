using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public LayerMask blockLayer; // 设置方块的层级
    public float moveSpeed = 5f; // 设置角色移动速度

    private bool isMoving = false; // 检测是否正在移动
    private Vector3 targetPosition; // 记录目标位置

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, blockLayer))
            {
                // 点击到了方块
                MoveToTrack(hit.collider.gameObject);
            }
        }

        // 角色移动
        if (isMoving)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, step);

            // 检查是否接近目标位置
            if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
            {
                isMoving = false;
            }
        }
    }

    void MoveToTrack(GameObject block)
    {
        // 假设軌道是方块的子物体，命名为 "Track"
        Transform track = block.transform.Find("Track");

        if (track != null)
        {
            // 设置目标位置为軌道的位置
            targetPosition = new Vector3(track.position.x, transform.position.y, track.position.z);
            isMoving = true;
        }
        else
        {
            Debug.LogWarning("No track found on the clicked block.");
        }
    }
}
