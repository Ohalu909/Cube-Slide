using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //this is a reference to the rigid body component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    

    // Update is called once per frame
    //"Fixed"Update is use to mess with physics
    void FixedUpdate()
    {
        //add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0 ,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager1>().EndGame();

        }
    }

    
}

