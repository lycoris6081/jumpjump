using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    private bool isYellow = true;
    private bool canSwitch = true; // 添加一个标志位

    private void OnMouseDown()
    {
        // 检查是否允许切换颜色
        if (canSwitch)
        {
            SwitchColors();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // 检查进入触发器的对象是否是角色，并且角色是黄色
        if (other.CompareTag("Player") && other.GetComponent<Renderer>().material.color == Color.yellow)
        {
            canSwitch = true; // 允许点击
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // 检查离开触发器的对象是否是角色
        if (other.CompareTag("Player"))
        {
            canSwitch = false; // 不允许点击
        }
    }

    private void SwitchColors()
    {
        if (isYellow)
        {
            // 将黄色方块变成白色
            GetComponent<Renderer>().material.color = Color.white;

            // 获取角色对象
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            // 将角色变成黄色
            player.GetComponent<Renderer>().material.color = Color.yellow;

            isYellow = false;
            canSwitch = false; // 切换后不允许再次点击
        }
        else
        {
            // 还原为黄色方块和白色角色
            GetComponent<Renderer>().material.color = Color.yellow;

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<Renderer>().material.color = Color.white;

            isYellow = true;
            canSwitch = false; // 切换后不允许再次点击
        }
    }
}


