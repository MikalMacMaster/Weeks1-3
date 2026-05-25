
using UnityEngine;

public class Bubbles : MonoBehaviour
{
    public float speed;
    public float top;
    public float bottom;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.y > top)
        {
            transform.position = new Vector3(transform.position.x, bottom, transform.position.z);
        }
    }
}
