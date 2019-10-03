using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CameraActivate;
    public GameObject CameraDeactivate;

    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            CameraActivate.SetActive(true);
            CameraDeactivate.SetActive(false);
        }
    }
}
