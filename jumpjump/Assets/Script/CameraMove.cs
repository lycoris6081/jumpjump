using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetPosition; // 目标位置
    public float moveSpeed = 2f; // 移动速度
    //public GameObject objectToClose; // 需要关闭的物体
    //public GameObject objectToOpen;
    private bool hasReachedTarget = false;


        void Update()
    {
        if (!hasReachedTarget)
        {
            Invoke("Move", 1f);

        }

        // 计算当前位置与目标位置的距离
        float distance = Vector3.Distance(transform.position, targetPosition.position);

        // 如果距离小于0.1，关闭物体
        if (distance < 0.1f)
        {
            //CloseObject();
            hasReachedTarget = true;
        }
    }

    void Move()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
    }

    //void CloseObject()
    //{
    //    // 关闭物体（可以设置为SetActive(false)或其他关闭逻辑）
    //    objectToClose.SetActive(false);
    //    objectToOpen.SetActive(true);

    //}
}