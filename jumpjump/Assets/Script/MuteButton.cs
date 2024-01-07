using UnityEngine;

public class MuteButton : MonoBehaviour
{
    private bool isMuted = false;

    // �b���s�W�]�m�o�Ӥ�k�A�o�˷���s�Q�I���ɷ|�եθӤ�k
    public void ToggleMute()
    {
        isMuted = !isMuted;

        // ����Ҧ�AudioSource�ե�
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        // �j��M���C��AudioSource�A�]�m���q
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = isMuted;
        }
    }
}
