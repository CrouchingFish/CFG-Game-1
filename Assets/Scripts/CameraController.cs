using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Player thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMoveX;
    private float distanceToMoveY;


    void Start()
    {
        //thePlayer = FindObjectOfType<PlayerController>();
        thePlayer = FindObjectOfType<Player>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    void Update()
    {
        distanceToMoveX = thePlayer.transform.position.x - lastPlayerPosition.x;
        distanceToMoveY = thePlayer.transform.position.y - lastPlayerPosition.y;

        transform.position = new Vector3(transform.position.x + distanceToMoveX, transform.position.y + distanceToMoveY, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
    }
}
