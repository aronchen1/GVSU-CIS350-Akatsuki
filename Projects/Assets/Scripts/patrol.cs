using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed;

    private bool goingRight = true;

    public Transform groundDetection;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 3f);
 
        if(groundInfo.collider == false){
            if(goingRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                goingRight = false;
            } 
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                goingRight = true;
            }
        }

    }
}
