using UnityEngine;

public class Crab : MonoBehaviour
{
    public float speed;
    public float leftEdge;
    public float rightEdge;
    public float shuffleAmount = 0.5f;
    public float shuffleSpeed = 8f;

    private int direction = 1;
    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        startX += direction * speed * Time.deltaTime;

        float shuffleOffset = Mathf.Sin(Time.time * shuffleSpeed) * shuffleAmount;
        transform.position = new Vector3(startX + shuffleOffset, transform.position.y, transform.position.z);

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