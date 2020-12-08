using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class death : MonoBehaviour
{
    public bool isDead;
    public int minHeight = -20;

    public int lives = 3;
    public float invincible = 2;
    // Start is called before the first frame update
    void Start()
    {
       isDead = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        if( gameObject.transform.position.y < minHeight){
            lives = 3;
            isDead = true;
        }
 
        if (isDead == true){
            StartCoroutine ("Die");
        }
    }
 
    IEnumerator Die (){
        SceneManager.LoadScene ("Game");
         return null;
    }

    void hurt(){
        lives --;
        if(lives <= 0){
            isDead = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        patrol enemy = collision.collider.GetComponent<patrol>();
        if(enemy != null){
            hurt();
        }
    
    }
    
    
}
