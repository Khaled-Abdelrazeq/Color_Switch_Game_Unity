using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject GameoverPanel;

    public static PauseGame Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void onPauseButtonClicked()
    {
        Time.timeScale = 0;
    }

    public void onResumeButtonClicked()
    {
        Time.timeScale = 1;
    }

    public void onMainButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void onRestartButtonClicked()
    {
        Time.timeScale = 1;
        PlayerScore.Instance.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowGameOverPanel()
    {
        PausePanel.SetActive(false);
        GameoverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
