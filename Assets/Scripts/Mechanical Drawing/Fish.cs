using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;
    public float leftEdge;
    public float rightEdge;

    private int direction = 1;

    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        if (transform.position.x >= rightEdge)
        {
            direction = -1;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (transform.position.x <= leftEdge)
        {
            direction = 1;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}