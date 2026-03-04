using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float horizontalInput;
    public GameObject projectilePrefab;

    void Update()
    {
        // Left boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Right boundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get input
        horizontalInput = Input.GetAxis("Horizontal");

        // Move player
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}