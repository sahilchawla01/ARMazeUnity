using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static public GameController game;
    public GameObject player;
    public GameObject menu;
    public GameObject buttons;
    Vector3 playerStartPos;
    Quaternion playerStartRot;

    void OnEnable()
    {
        game = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerStartPos = player.transform.localPosition;
        playerStartRot = player.transform.localRotation;
        Debug.Log("Pos: " + playerStartPos + " Rot: " + playerStartRot.eulerAngles);
        ShowUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUI()
    {
        player.SetActive(false);
        menu.SetActive(true);
        buttons.SetActive(false);
        player.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    public void HideUI()
    {
        player.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.transform.SetLocalPositionAndRotation(playerStartPos, playerStartRot);
        //  = playerStartPos;
        // player.transform.rotation = playerStartRot;
        player.SetActive(true);
        menu.SetActive(false);
        buttons.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
