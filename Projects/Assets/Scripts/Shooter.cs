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
 
   void FixedUpdate(){
    //   // Vector2 lineCastPos = myTrans.position.toVector2() - myTrans.right.toVector2() * myWidth + Vector2.up * myHeight;
    //   //  Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
    //     bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
    //     Debug.DrawLine(lineCastPos, lineCastPos - myTrans.right.toVector2() * .02f);
    //     bool isBlocked = Physics2D.Linecast (lineCastPos, lineCastPos - myTrans.right.toVector2() * .02f, enemyMask);
    //     //if(!isGrounded || isBlocked ){
    //      //   Vector3 currRot = myTrans.eulerAngles;
    //      //   currRot.y += 180;
    //     // //   myTrans.eulerAngles = currRot;
    //     }
 
    //    Vector2 myVel = myBody.velocity;
    //    myVel.x = -myTrans.right.x * speed;
    //    myBody.velocity = myVel;
   }
    // [SerializeField]
    // GameObject bullet;

    // float fireRate;
    // float nextFire;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     fireRate = 4f;
    //     nextFire = Time.time;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     CheckIfTimeToFire();
    // }

    // void CheckIfTimeToFire(){
    //     if (Time.time > nextFire){
    //         Instantiate (bullet, transform.position, Quarternion.identity);
    //         nextFire = Time.time + fireRate;
    //     }
    // }
}
