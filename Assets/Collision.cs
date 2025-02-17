using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! I hit something!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("What was that!");
    }
}
