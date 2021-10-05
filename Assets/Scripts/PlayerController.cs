using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private CapsuleCollider collider;
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
    }

   private void OnCollisionEnter(Collision collision) 
   {
       if (collision.gameObject.tag == "Virus")
       {
           GameController.instance.GameOver();

       }
   }
}
