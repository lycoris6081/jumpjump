﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject player; // 角色对象
    public GameObject Block;
    public GameObject whiteBlock;
    public Color color;

    void Update()
    {
        // 检查鼠标左键点击
        if (Input.GetMouseButtonDown(0))
        {
            CheckClick();
        }


    }

    void CheckClick()
    {
        // 检查角色是否在黄色方块上
        if (IsPlayerOnBlock(player, Block))
        {
            // 如果黄色方块被点击且角色颜色不同
            if (IsMouseOnBlock(Block) && player.GetComponent<Renderer>().material.color != color)
            {
                SwitchColors(Block, whiteBlock, color, Color.white);
            }
        }
        // 检查角色是否在白色方块上
        else if (IsPlayerOnBlock(player, whiteBlock))
        {
            // 如果白色方块被点击且角色颜色不同
            if (IsMouseOnBlock(whiteBlock) && player.GetComponent<Renderer>().material.color != Color.white)
            {
                SwitchColors(whiteBlock, Block, Color.white, color);
            }
        }
    }

    bool IsPlayerOnBlock(GameObject player, GameObject block)
    {
        // 判断角色是否与方块接触
        Collider playerCollider = player.GetComponent<Collider>();
        Collider blockCollider = block.GetComponent<Collider>();

        return playerCollider.bounds.Intersects(blockCollider.bounds);
    }

    bool IsMouseOnBlock(GameObject block)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Clicked on: " + hit.collider.gameObject.name);
            Debug.Log("Hit point: " + hit.point);
            // ...其他逻辑
        }

        // 射线检测
        return Physics.Raycast(ray, out hit) && hit.collider.gameObject == block;
    }

    void SwitchColors(GameObject clickedBlock, GameObject otherBlock, Color playerColor, Color otherColor)
    {
        // 将角色颜色切换
        player.GetComponent<Renderer>().material.color = playerColor;

        // 将点击的方块消失
        clickedBlock.SetActive(false);

        // 将另一个方块出现
        otherBlock.SetActive(true);
    }
}

