using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float sceneTimeDelay = 0.25f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ground"))
        {
            crashEffect.Play();
            Invoke(nameof(ReloadScene), sceneTimeDelay);
        }
    }

    void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
}
