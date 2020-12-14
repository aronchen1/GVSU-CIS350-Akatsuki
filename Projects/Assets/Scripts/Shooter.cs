using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public LayerMask enemyMask;
   public float speed;
   Rigidbody2D myBody;
   Transform myTrans;
    float myWidth;
    float myHeight;
 
   void Start(){
       myTrans = this.transform;
       myBody = this.GetComponent<Rigidbody2D>();
       SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
       myWidth = mySprite.bounds.extents.x;
       myHeight = mySprite.bounds.extents.x;
 
   }
 
}
