using UnityEngine;

public class Driver : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0,0,.1f);
        transform.Translate(0, .01f, 0);
        
    }
}
