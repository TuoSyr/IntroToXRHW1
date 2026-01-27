using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    public Color DEFAULT;
    public Color SWITCH;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light.color = DEFAULT;
        action.action.Enable();
        action.action.performed += (ctx) => 
	    {
	        if (light.color == DEFAULT) {
                light.color = SWITCH;
            }
            else {
                light.color = DEFAULT;
            }
	    };
    }
}
