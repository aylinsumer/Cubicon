using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "obstacle")
       {
           //Debug.Log("We hit an obstacle!");
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       }
      
       // Debug.Log(collisionInfo.collider.name);
    }


}
