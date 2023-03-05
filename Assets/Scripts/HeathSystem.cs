using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeathSystem : MonoBehaviour
{
    public Transform Player;
    public Transform respawnPoint;

    public int lives;
    
   
  
  void OnTriggerEnter(Collider other)
   {
    
      if (other.gameObject.CompareTag("Player"))
      {
         Death();
      }
 
  
    
   
   }

   private void Death()
   {

      
      Invoke(nameof(playerRespawn), 0.7f);
   }

   private void playerRespawn()
   {
        Player.transform.position = respawnPoint.transform.position;
        lives = lives -1;
   }

   
}
