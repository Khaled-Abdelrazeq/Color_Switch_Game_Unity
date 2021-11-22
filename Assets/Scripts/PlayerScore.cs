using TMPro;
using UnityEngine;
using UnityEngine.UI;
    public class PlayerScore : MonoBehaviour
{
    public int Score;
    [SerializeField] private Text scoreValueText;
    [SerializeField] private TextMeshProUGUI scoreMesh;

    public static PlayerScore Instance;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Update()
    {
        scoreValueText.text = Score.ToString();
        scoreMesh.text = Score.ToString();
    }

    public void IncreaseScore(int ScoreValue)
    {
        Score += ScoreValue;
    }
    
}
