using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using TMPro;

public class usernameCanvas : MonoBehaviour
{

    [SerializeField] PhotonView _photonView;
    [Space]
    [SerializeField] TMP_Text _usernameText;
    [SerializeField] GameObject _usernameCanvas;
    // Start is called before the first frame update
  
    void Awake()
    {
        //TODO: Set Username
        SetUsername();
       // Debug.Log(22);

    }







    void Start()
    {
       
    }
    void SetUsername()
    {
        if (!_photonView.IsMine)
        {
            _usernameCanvas.SetActive(true);
            _usernameText.text = _photonView.Owner.NickName;
            //GlobalUsernames.usernameList.Add(_usernameText.text);
        }
    }

    public static void valueUpdate()
    {

      //  mapscript.myMap[_photonView.Owner.NickName] -= 2;
     //   Debug.Log(mapscript.myMap[_photonView.Owner.NickName]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
