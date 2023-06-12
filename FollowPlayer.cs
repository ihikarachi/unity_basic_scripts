
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 pos;  
    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + pos;
        transform.position = player.position + pos;

        
    }
}
