using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    // This function will be called when the button is clicked
    public void QuitGame()
    {
        
        Application.Quit();

        
        Debug.Log("Game is exiting...");
    }
}
