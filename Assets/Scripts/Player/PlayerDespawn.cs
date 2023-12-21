using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerDespawn : MonoBehaviour
{
 // Time before return to Main Screen
    public float DeathScreenTime = 1f;

    // Variables for Player object and its animatior
    private GameObject player;
    private Animator anim; 

    // Variables to get Player Input
    private PlayerInput playerInputsControl;


    void Start() {

        // Define Player Components
        player = GameObject.FindWithTag("Player");
        anim = player.GetComponent<Animator>();

        // Define PlayerInput Components
        playerInputsControl = player.GetComponent<PlayerInput>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Collision")
        {
            // Trigger the Death Animation
            this.GetComponent<Animator>().SetTrigger("Death");

            // Stop Player Inputs
            playerInputsControl.playerInputs = false;

            // wait before going back to to Main Menu
            StartCoroutine(Wait(DeathScreenTime));
            //Destroy(objectToDespawn);
        
        }
    }

    // wait for x amount of seconds, then reload to the main menu
    IEnumerator Wait(float seconds){

        yield return new WaitForSecondsRealtime(seconds);

        // Reload Main Menu 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
