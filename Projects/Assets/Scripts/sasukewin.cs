using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sasukewin : MonoBehaviour
{
//    void OnCollisionEnter2D(Collision2D collision){
//         BasicMovement player = collision.collider.GetComponent<BasicMovement>();
//         if(player != null){
//             Debug.Log("hit");
//             SceneManager.LoadScene("End");
//         }
    
//     }

void OnTriggerEnter2D(Collider2D other){
            Debug.Log("hit");
            SceneManager.LoadScene("End");
}
}
