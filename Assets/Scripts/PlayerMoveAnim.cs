using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMoveAnim : MonoBehaviour
{
    [SerializeField] private float velocity = 1.3f;
    private Animator animator;
    private CharacterController charController;
    void Start()
    {
        charController = gameObject.GetComponent<CharacterController>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(h, 0, v);
        float MovingSpeed = velocity * moveDirection.magnitude;
        if (MovingSpeed > 0.1f)
        {
            animator.SetFloat("MovingSpeed", MovingSpeed);
        } else
        {
            animator.SetFloat("MovingSpeed", 0.0f);
        }
        // Debug.Log(MovingSpeed);
        transform.LookAt(transform.position + moveDirection);
        moveDirection.y += Physics.gravity.y;
        charController.Move(velocity * Time.deltaTime * moveDirection);
    }

    // for animation "Walk_N"
    public void OnFootstep()
    {
        Debug.Log("Footstep event triggered");
    }
}
