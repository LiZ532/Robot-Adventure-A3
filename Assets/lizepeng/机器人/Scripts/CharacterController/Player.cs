using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text text;
    public GameObject winPage;
    public AudioSource audioSource; // 引用AudioSource组件
    int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            Destroy(other.gameObject);
            score += 1;
            text.text = score.ToString();
            if (score == 6)
            {
                winPage.SetActive(true);
            }

        }
    }
}
