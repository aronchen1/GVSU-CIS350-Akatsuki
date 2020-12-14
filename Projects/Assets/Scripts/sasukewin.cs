using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sasukewin : MonoBehaviour
{
    public LayerMask enemyMask;
   public float speed;
   Rigidbody2D myBody;
   Transform myTrans;
    float myWidth;
    float myHeight;
    BasicMovement enemy;
 
   void Start(){
       myTrans = this.transform;
       myBody = this.GetComponent<Rigidbody2D>();
       SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
       myWidth = mySprite.bounds.extents.x;
       myHeight = mySprite.bounds.extents.x;
 
   }

   void OnCollisionEnter2D(Collision2D collision){
        BasicMovement enemy = collision.collider.GetComponent<BasicMovement>();
        if(enemy != null){
            SceneManager.LoadScene("End");
        }
    
    }
}
