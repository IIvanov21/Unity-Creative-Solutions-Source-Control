using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput = 0.0f;
    private float verticalInput = 0.0f;

    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private float rotationSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Capture Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moving the car backwards/forwards
        transform.Translate(Vector3.forward*speed*Time.deltaTime*verticalInput);

        //Rotating the car left/right
        transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime*horizontalInput);
    }
}
