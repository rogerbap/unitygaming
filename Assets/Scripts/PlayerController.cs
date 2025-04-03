using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame


    void Update()
    {
        // Unity uses string "Horizontal" in input manager to press left/right key
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the vehicle forward
        //transform.Translate(0,0,1);
        //deltaTime is used to ensure the intended object moves at the same speed regardless of FPS
        //Vector3 is the 3 points/position instead of using (0,0,1)
        
        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
