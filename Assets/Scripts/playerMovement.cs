using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public int vforce;
    public int hforce;
    [SerializeField] PhotonView _photonView;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    public void Movement()
    {
        if (_photonView.IsMine)
        {

            
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(0.1f, 0f, 0f);
                }
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(-0.1f, 0f, 0f);
                }
                if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                {
                    transform.Translate(0.0f, 0f, -0.1f);
                }
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                {
                    transform.Translate(0.0f, 0f, 0.1f);
                }
            
           
            
        }

    }
    void Update()                   
    {

        Movement();
    }
}
