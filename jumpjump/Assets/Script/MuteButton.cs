using UnityEngine;

public class MuteButton : MonoBehaviour
{
    private bool isMuted = false;

    // 在按鈕上設置這個方法，這樣當按鈕被點擊時會調用該方法
    public void ToggleMute()
    {
        isMuted = !isMuted;

        // 獲取所有AudioSource組件
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        // 迴圈遍歷每個AudioSource，設置音量
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = isMuted;
        }
    }
}
