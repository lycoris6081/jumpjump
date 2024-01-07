using UnityEngine;
using UnityEngine.UI;

public class ToggleImages : MonoBehaviour
{
    public GameObject container; // ��m Image �M Button ���e������
    public Button button1;
    public Button button2;
    public Button button3;
    public Image image1;
    public Image image2;

    private bool isVisible = false;

    void Start()
    {
        // ��l�ɱN�e������ Image �M Button �]�m�����i��
        SetContainerVisibility(false);
    }

    public void ToggleVisibility()
    {
        // �����i����
        isVisible = !isVisible;

        // �ھڥثe���i���ʳ]�m�e������ Image �M Button ���i����
        SetContainerVisibility(isVisible);
    }

    private void SetContainerVisibility(bool visible)
    {
        // �]�m�e�����i����
        if (container != null)
        {
            container.SetActive(visible);
        }
    }
}
