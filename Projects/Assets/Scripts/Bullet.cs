using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{

    public float speed;
    public BasicMovement player;
    public GameObject impactDeath;
	public GameObject impactEffect;
    public float rotationSpeed;
    public int damageToGive;
    private Rigidbody2D myridgidbody2D;

    void Start (){
        player = FindObjectOfType<BasicMovement>();

        myridgidbody2D = GetComponent<Rigidbody2D>();

        // if(player.transform.position.x < transform.position.x){
            speed = -speed;
            rotationSpeed = -rotationSpeed;
        // }
    }

    void Update(){
        myridgidbody2D.velocity = new Vector2(speed, myridgidbody2D.velocity.y);
        myridgidbody2D.angularVelocity = rotationSpeed;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            ///do somthing to kill player
        SceneManager.LoadScene ("Game");
        }

        Instantiate (impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
