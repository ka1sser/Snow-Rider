using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float sceneTimeDelay = 0.25f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ground"))
        {
            Invoke(nameof(ReloadScene), sceneTimeDelay);
        }
    }

    void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
}
