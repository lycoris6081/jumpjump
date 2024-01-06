using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YellowBlock"))
        {
            // 如果角色碰到黄色方块，启用黄色方块的交互
            other.GetComponent<ColorSwitcher>().enabled = true;
        }
    }
}
