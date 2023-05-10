using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using TMPro;

public class GoalManager : MonoBehaviour
{
    [SerializeField] PhotonView _photonView;
 

    private GameObject ok1;
    public TextMeshProUGUI playerCount;

    public GameObject targetPlayer;
    public string levelName = "Goal";
    private int s = 0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(mapscript.numplay==1&&s==0)
        {
            SceneManager.LoadScene("Goal"); s = 1;
        }
        playerCount.text = "Players Remaining : " + mapscript.numplay.ToString();
    }
    
    private bool isDestroyed = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isDestroyed)
        {
            if ( (collision.gameObject.tag == "Player"))
            {
                ok1 = collision.gameObject;
              _photonView.RPC("DestroyCubeAndPlayer", RpcTarget.AllBuffered);
            }
        }


}



    [PunRPC]
    private void DestroyCubeAndPlayer()
    {
        if (!isDestroyed)
        {
            isDestroyed = true;
           mapscript.numplay -= 1;
            // Destroy the cube object on all clients
            PhotonNetwork.Destroy(gameObject);
            PhotonNetwork.Destroy(ok1);
            usernameCanvas.valueUpdate();


           
        }
    }
}






