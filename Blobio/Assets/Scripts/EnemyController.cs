using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    
    void OnTriggerEnter(Collider other)
    {
        Vector3 otherLocalScale = other.gameObject.transform.localScale;
        Vector3 thisLocalScale = this.gameObject.transform.localScale;
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (otherLocalScale.magnitude > thisLocalScale.magnitude)  //check if the player is larger than the enemy
            {
                //Debug.Log("Çalışıyorrrrrrrrrrrrrrr?");
                other.gameObject.transform.localScale += this.gameObject.transform.localScale;
                Destroy(this.gameObject);
            }
        }
    }

}
