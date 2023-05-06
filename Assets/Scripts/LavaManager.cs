using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Transform origin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = origin.transform.position;
        }
    }
}
