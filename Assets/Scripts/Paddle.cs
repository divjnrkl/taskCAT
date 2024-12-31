using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{  
   public float speed = 30.0f;
   protected Rigidbody2D rigidBody;

   private void Awake() 
   {
    rigidBody = GetComponent<Rigidbody2D>();
   }


}

