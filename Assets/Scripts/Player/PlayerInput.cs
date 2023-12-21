using UnityEngine;

public class PlayerInput : MonoBehaviour
{
 // Variables for Player Components
    private GameObject player;
    private Rigidbody playerRigidBody;
    private Animator anim; 


    // Fly/ Gravity Control Parameters
    private float timer = 0;
    public float gravitydelay = 0.2f;
    public float gravitydown = -9.81f;
    public float gravityup = 9.81f;
    public float GravityDifficultyMultiplier = 1f;

    // Situation Check Variables
    public bool playerInputs = true;

    void Update()
    {
        // Fly / Swim
        if (playerInputs == true)  
        {

            if (Input.GetButton("Jump")) {

                timer += Time.deltaTime;

                if (timer > gravitydelay) {
                    //Change Gravity
                    Physics.gravity = new Vector3(0, gravityup, 0);
                    timer = 0;
                }

                // Enable Jump Animation (Return to Run Animation)
                this.GetComponent<Animator>().SetBool("Swim", true);

            }
            else {

                Physics.gravity = new Vector3(0, gravitydown, 0);

                // Disable Jump Animation (Return to Run Animation)
                this.GetComponent<Animator>().SetBool("Swim", false);
            }
        }
    }

}
