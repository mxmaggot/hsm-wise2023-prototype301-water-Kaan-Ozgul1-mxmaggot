using UnityEngine;

public class CollisionDespawn : MonoBehaviour
{
  // Destroy GameObject once it hits the Despawner GameObject
  void OnCollisionEnter (Collision collision)
  {
    if (collision.collider.tag == "Collision")
    {

      GameObject collisionObject;
      collisionObject = collision.gameObject;
      
      Destroy(collisionObject);
      
    }
  }
}
