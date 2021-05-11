using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
   public Animator anim;
   void OnTriggerEnter2D(Collider2D cologne)
   {
      if (cologne.gameObject.tag == "Player")
      {
         anim.SetTrigger("Player");
      }
   }
}
