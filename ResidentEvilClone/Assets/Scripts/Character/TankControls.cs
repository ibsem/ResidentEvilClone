using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            thePlayer.GetComponent<Animator>().Play("Walk");
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving = false;
            thePlayer.GetComponent<Animator>().Play("Idle");
        }
    }
}
