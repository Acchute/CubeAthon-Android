using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 3000f;
    public float sidewardForce = 500f;
    public static bool leftKeyPressed;
    public static bool rightKeyPressed;



    void Update()
    {
        rightKeyPressed = false;
        leftKeyPressed = false;
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rightKeyPressed = true;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            leftKeyPressed = true;
        }
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        
        if(rightKeyPressed)
        {
            rb.AddForce(sidewardForce  * Time.deltaTime,0,0 );
        }
        if(leftKeyPressed)
        {
            rb.AddForce(-sidewardForce  * Time.deltaTime, 0, 0);
        }
		if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
