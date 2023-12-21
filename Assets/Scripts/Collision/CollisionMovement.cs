using UnityEngine;

public class CollisionMovement : MonoBehaviour
{
public float MovementSpeedMultiplier = 50;

    // public because it has to be set to 0 when the player dies
    //[HideInInspector] 
    public float MovementSpeed = -1f;
    
    //public float speed;
    private Vector3 collisionForce = new Vector3(0, 0, 0); 

    // Reference Collision Object
    //private GameObject collisionObject;
    private CollisionSpawn collisionInstance;
    private Rigidbody collisionObjectRigid;

    // Reference Spawner
    private GameObject spawner;


    void Start(){

        // get Obstacle and Background GameObject's
        //collisionObject = GameObject.FindWithTag("Collision");
        
        spawner = GameObject.FindWithTag("Spawner");
        collisionInstance = spawner.GetComponent<CollisionSpawn>();
        collisionObjectRigid = collisionInstance.CollisionInstance.GetComponent<Rigidbody>();


        // get the speed of the Background
        collisionForce.x = (MovementSpeed*(-1)) * MovementSpeedMultiplier;

        // set the CollisionObjects Speed to the Backgrounds Speed
        collisionObjectRigid.AddForce(collisionForce, ForceMode.VelocityChange);

    }

}
