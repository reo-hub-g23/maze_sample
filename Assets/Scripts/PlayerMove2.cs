using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMove2 : MonoBehaviour
{
    [SerializeField] private float velocity = 1.3f;
    private CharacterController charController;
    void Start()
    {
        charController = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(h, 0, v);
        moveDirection.y += Physics.gravity.y;
        charController.Move(velocity * Time.deltaTime * moveDirection);
    }
}