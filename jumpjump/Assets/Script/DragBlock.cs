using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBlock : MonoBehaviour
{
    public static bool Dragging;
    private float offsetX;
    private RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && hit.collider.CompareTag("Drag") && !IsPlayerOnBlock())
            {
                Dragging = true;
                offsetX = hit.point.x - hit.collider.transform.position.x;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Dragging = false;
        }

        if (Dragging)
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

            // 只修改 X 轴的值
            float newX = mouseWorldPosition.x - offsetX;
            float newY = hit.collider.transform.position.y; // 保持 Y 轴不变
            float newZ = hit.collider.transform.position.z; // 保持 Z 轴不变

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
