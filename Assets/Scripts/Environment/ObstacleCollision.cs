using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject chartModel;
    public AudioSource crashThud;
    public GameObject mainCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        chartModel.GetComponent<Animator>().Play("Stumble Backwards");
        crashThud.Play();
        mainCam.GetComponent<Animator>().enabled = true;
    }
}
