using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update 
    int hits = 0;
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Hit"){
            Debug.Log("Already hit lol");
        }
        else {
            hits ++;
            Debug.Log("You have bumped into a thing this many times:" + hits);
        }
        
    }
}
