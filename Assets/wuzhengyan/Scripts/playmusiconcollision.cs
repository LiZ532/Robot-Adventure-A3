using UnityEngine;

public class PlayMusicOnCollision : MonoBehaviour
{
    public AudioClip musicClip; // 音乐音频剪辑
    private AudioSource audioSource; // AudioSource组件

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // 获取AudioSource组件
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 碰撞发生在标签为“Player”的对象上
        {
            audioSource.clip = musicClip; // 设置音频剪辑
            audioSource.Play(); // 播放音乐
        }
    }
}
