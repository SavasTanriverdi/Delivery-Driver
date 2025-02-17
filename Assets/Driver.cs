using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // -1 to 1 for left and right
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // -1 to 1 for forward and back
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
