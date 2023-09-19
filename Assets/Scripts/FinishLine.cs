using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float sceneTimeDelay = 1f;
    SurfaceEffector2D surfaceEffector2D;
    PlayerController playerController;
    
    void Start()
    {
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        playerController = FindObjectOfType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            surfaceEffector2D.speed = 0f;
            playerController.DisableControls();
            Invoke(nameof(ReloadScene), sceneTimeDelay);
        }
    }

    void ReloadScene()
        {
            SceneManager.LoadScene(0);
        }
} 
