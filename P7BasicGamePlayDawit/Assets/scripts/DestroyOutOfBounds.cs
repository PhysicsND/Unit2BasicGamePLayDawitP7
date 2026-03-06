using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private const int V = 20;
    private float topBound = -30;
    private float lowerBound = V;

    void Update()
    {
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > lowerBound)
        {
            Destroy(gameObject);
        }


    }
}