using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private Animator anim;

    public float jumpForce = 10f;
    public bool playerInputs = true;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerInputs)
        {
            if (Input.GetButtonDown("Jump")) // "Jump" ist der Name der Leertaste
            {
                Jump();
            }
        }
    }

    void Jump()
    {
        playerRigidBody.velocity = new Vector3(playerRigidBody.velocity.x, jumpForce, playerRigidBody.velocity.z);
        anim.SetBool("Swim", true); // Hier musst du den Namen der Animation anpassen
    }
}
