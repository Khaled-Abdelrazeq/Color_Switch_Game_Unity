using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    
    public void onPlayButtonClicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void onQuitButtonClicked()
    {
        Application.Quit();
    }
}
