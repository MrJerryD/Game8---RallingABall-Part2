using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndGame"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
