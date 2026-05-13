using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float duration;
    float progress = 0f;
    public Vector2 newPosition;
    public float newPositionX;
    public float newPositionY;
    float xMax = 10f;
    float xMin = -10f;
    float yMax = 5f;
    float yMin = -5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        //Debug.Log(progress); 

        if (progress >= duration)
        {
            newPosition = new Vector2 (newPositionX, newPositionY);
            newPositionX = Random.Range(xMin, xMax);
            newPositionY = Random.Range(yMin, yMax);
            transform.position = newPosition;
            progress = 0f;
        }

        
    }
}
