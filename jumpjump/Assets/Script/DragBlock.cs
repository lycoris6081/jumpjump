﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBlock : MonoBehaviour
{
    public static bool Dragging;
    private float offsetX;  // 仅保留 X 轴的偏移
    private RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Drag") && !IsPlayerOnBlock())
            {
                Dragging = true;
                // 记录物体中心相对于点击点的 X 轴偏移量
                offsetX = hit.collider.transform.position.x - ray.GetPoint(hit.distance).x;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Dragging = false;
        }

        if (Dragging)
        {
            // 计算鼠标在世界坐标系中的位置
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

            // 仅修改 X 轴的值
            float newX = mouseWorldPosition.x-offsetX;
            // 保持 Y 和 Z 轴不变
            float newY = hit.collider.transform.position.y;
            float newZ = hit.collider.transform.position.z;
            // 设置物体位置
            hit.collider.transform.position = new Vector3(newX, newY, newZ);
        }
    }

    bool IsPlayerOnBlock()
    {
        // 判断角色是否与方块接触
        Collider playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>();
        Collider blockCollider = hit.collider;

        return playerCollider.bounds.Intersects(blockCollider.bounds);
    }
}

