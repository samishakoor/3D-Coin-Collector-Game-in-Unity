using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3D : MonoBehaviour
{

    Rigidbody rb;
    float xInput;
    float zInput;


    public float xSpeed=1f;
    public float ySpeed=1f;

    public float moveSpeed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Called");

    }

    // Update is called once per frame
    void Update()
    {

        //xInput = Input.GetAxis("Horizontal");
        //zInput = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position -= new Vector3(0, 0, ySpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, ySpeed);
        }


    }


    private void FixedUpdate()
    {
        //float xVelocity = xInput * moveSpeed;
        //float zVelocity = xInput * moveSpeed;
        //rb.velocity=new Vector3(xVelocity,rb.velocity.y,zVelocity);

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Occured");
        if (collision.gameObject.tag == "coin") 
        {
            Destroy(collision.gameObject);
        }
    }

}
