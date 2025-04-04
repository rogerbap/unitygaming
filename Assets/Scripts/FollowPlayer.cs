using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(50,5,-15);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //LateUpdate updates after method happens thus avoiding the laggy jittery look since vehicle moves first
    void LateUpdate()
    {
        //Offset the camera behind the player by adding to player's position and to follow vehicle
        transform.position = player.transform.position + offset;
    }
}
