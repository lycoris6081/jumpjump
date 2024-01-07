using UnityEngine;
using UnityEngine.UI;

public class ToggleImages : MonoBehaviour
{
    public GameObject container; // 放置 Image 和 Button 的容器物件
    public Button button1;
    public Button button2;
    public Button button3;
    public Image image1;
    public Image image2;

    private bool isVisible = false;

    void Start()
    {
        // 初始時將容器中的 Image 和 Button 設置為不可視
        SetContainerVisibility(false);
    }

    public void ToggleVisibility()
    {
        // 切換可視性
        isVisible = !isVisible;

        // 根據目前的可視性設置容器中的 Image 和 Button 的可視性
        SetContainerVisibility(isVisible);
    }

    private void SetContainerVisibility(bool visible)
    {
        // 設置容器的可視性
        if (container != null)
        {
            container.SetActive(visible);
        }
    }
}
