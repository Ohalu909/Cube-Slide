
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    //this function runs when we hit another object
    //we get information about the collision and call it "collisionInfo"
     void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        //check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            //if movement.enabled = true the player will keep moving once collided with the obstacles
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    } 

}