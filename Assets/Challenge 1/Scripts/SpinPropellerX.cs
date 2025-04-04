using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
     public float spinSpeed = 3000.0f; // Speed of the propeller spin

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
