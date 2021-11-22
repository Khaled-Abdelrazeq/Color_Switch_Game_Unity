using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private void Update()
    {
        if(Player.Instance.player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Player.Instance.player.position.y, transform.position.z);
        }
    }
}
