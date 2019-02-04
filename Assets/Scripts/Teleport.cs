using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform[] teleportSpots;
    private PlayerController thePlayer;
    private CameraController theCamera;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theCamera = FindObjectOfType<CameraController>();
    }

     public void teleport (int idToTpTo)
    {
        thePlayer.transform.position = teleportSpots[idToTpTo].position;
        theCamera.transform.position = new Vector3(teleportSpots[idToTpTo].position.x, teleportSpots[idToTpTo].position.y, theCamera.transform.position.z);

    }
}
