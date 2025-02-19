using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;        
    }
}
