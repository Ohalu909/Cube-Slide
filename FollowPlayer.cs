
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position can be used for first person view
        transform.position = player.position + offset;
    }
}
