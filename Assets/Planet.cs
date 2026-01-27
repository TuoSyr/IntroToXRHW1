using UnityEngine;

public class Planet : MonoBehaviour
{
    public Transform planet;
    public int rotationSpeed = 2;
    // Update is called once per frame
    void Update()
    {
        //planet.Rotate(Vector3.down);
        planet.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
    }
}
