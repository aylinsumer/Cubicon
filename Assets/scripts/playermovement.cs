using UnityEngine;

public class playermovement : MonoBehaviour
{
    // This is a reference ti the rigidbody component called "rb"
    public Rigidbody rb;
/*
    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        rb.AddForce(0, 200, 500);
    }
*/
    public float forwardForce = 2000f ; 
    public float sidewaysForce = 500f ;
    // Update is called once per frame
    // We mark this as "Fixed"Update because we are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forwardforce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        if(Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
