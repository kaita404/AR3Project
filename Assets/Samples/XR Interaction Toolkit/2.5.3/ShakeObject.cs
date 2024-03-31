using UnityEngine;

public class ShakeObject : MonoBehaviour
{
    // Set the speed and amount of shaking
    public float speed = 1.0f; // How fast it shakes
    public float amount = 1.0f; // How much it shakes

    private Vector3 originalPosition;

    private void Start()
    {
        // Save the original position of the object
        originalPosition = transform.position;
    }

    private void Update()
    {
        // Apply a sinusoidal shake effect to the object's position
        float shakeOffset = Mathf.Sin(Time.time * speed) * amount;
        transform.position = originalPosition + new Vector3(shakeOffset, 0f, 0f);
    }
}

