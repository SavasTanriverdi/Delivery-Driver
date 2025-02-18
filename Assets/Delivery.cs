using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = .5f;
    bool hasPackage = false;

    void Start()
    {
        Debug.Log(hasPackage);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! I hit something!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Customer is happy!");
            hasPackage = false;
        }
    }
}
