using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public bool isDead;
    public int minHeight = -20;
    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
       isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if( gameObject.transform.position.y < minHeight){
            lives = lives - 1;
            if (lives == 0){
                lives = 3;
            }
            isDead = true;
        }

        if (isDead == true){
            StartCoroutine ("Die");
        }
    }

    IEnumerator Die (){
        SceneManager.LoadScene ("Game");
        SceneManager.LoadScene ("")
         return null;
    }
}