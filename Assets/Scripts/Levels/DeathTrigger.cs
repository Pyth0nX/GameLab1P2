using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderOnTrigger2D : MonoBehaviour
{

    public string sceneToLoad;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("Enter");
            SceneManager.LoadScene("LoadMainMenu");
        }
    }
}