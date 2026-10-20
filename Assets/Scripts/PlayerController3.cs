using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody playerRB;
    public InputAction jumpAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
        jumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.triggered)
        {
            playerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        
    }
}
