using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public int vforce;
    public int hforce;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * vforce);
        }
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, 1) * hforce);
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, -1) * hforce);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * hforce);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(1, 0, 0) * hforce);
        }
    }
    void Update()                   
    {

        Movement();
    }
}
