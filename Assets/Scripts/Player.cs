using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int jumpForce = 10;
    
    private Rigidbody2D rb;

    public Transform player;

    public static Player Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = transform;

        PlayerRandomColor.Instance.ChangePlayerColor();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Mathf.Abs(transform.position.y) - Mathf.Abs(Camera.main.transform.position.y) >= 20)
        {
            PauseGame.Instance.ShowGameOverPanel();
            //print(Mathf.Abs(transform.position.y) - Mathf.Abs(Camera.main.transform.position.y));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorChanger"))
        {
            PlayerRandomColor.Instance.ChangePlayerColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.CompareTag(PlayerRandomColor.Instance.currentColor))       
        {
            // Add Score
            PlayerScore.Instance.IncreaseScore(1);

        }
        else
        {
            //Time.timeScale = 0;

            //Restart Game
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // GAMEOVER
            PauseGame.Instance.ShowGameOverPanel();
        }
    }
}
