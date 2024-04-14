using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text text;
    public GameObject winPage;
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
