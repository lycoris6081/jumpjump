using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        // 获取Renderer组件
        rend = GetComponent<Renderer>();

        // 检查是否有Material，并且至少有两个Material
        if (rend != null && rend.materials.Length >= 2)
        {
            // 调整Material的顺序，将第二个Material放在第一个位置
            Material[] materials = rend.materials;
            Material tempMaterial = materials[0];
            materials[0] = materials[1];
            materials[1] = tempMaterial;

            // 更新Renderer组件上的Materials数组
            rend.materials = materials;
        }
        else
        {
            Debug.LogWarning("Renderer组件或Material数量不足，请检查并确保有足够的Material。");
        }
    }
}
