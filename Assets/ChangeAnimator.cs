using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
   public void getAnimatorCatwalk(){
       this.GetComponent<Animator>().Play("Catwalk Walk Turn 180 Tight");
   }
   public void getAnimatorHiphop(){
       this.GetComponent<Animator>().Play("Hip Hop Dancing");
   }
   public void getAnimatorSilly(){
       this.GetComponent<Animator>().Play("Silly Dancing");
   }
}
