using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference action;
    public Transform player;
    public Transform platform;
    private Vector3 homeLocation;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        homeLocation = player.position;
        action.action.Enable();
	    action.action.performed += (ctx) =>
        {
            if (player.position == homeLocation)
            {
                player.position = platform.position;
            }
            
            else
            {
                player.position = homeLocation;
            }
        };
    }
}
