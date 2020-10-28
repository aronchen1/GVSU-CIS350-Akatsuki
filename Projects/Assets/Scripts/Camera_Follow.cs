using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform playerNaruto;

    void FixedUpdate()
    {
        transform.position = new Vector3(playerNaruto.position.x, playerNaruto.position.y, transform.position.z);
    }
}
