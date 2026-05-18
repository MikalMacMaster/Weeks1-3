using UnityEngine;

public class Search : MonoBehaviour
{
    // Two Vector2 variables for start and destination positions
    Vector2 startPos;
     Vector2 destPos;
    
    // t variable to track lerp progress (0 = start, 1 = destination)
    float t = 0f;

    void Start()
    {
        // Set starting position from the sprite's current transform position
        startPos = transform.position;
        
        // Pick a random destination to begin moving towards
        destPos = RandomPos();
    }

    void Update()
    {
        // Increment t each frame using deltaTime to move forward in time
        t += Time.deltaTime;
        
        // Lerp between start and destination using t as the interpolation value
        transform.position = Vector2.Lerp(startPos, destPos, t);

        // Once t reaches 1 the sprite has arrived, so pick a new destination
        if (t >= 1f)
            NewDestination();
    }

    void NewDestination()
    {
        // Update start to current position so movement continues from here
        startPos = transform.position;
        
        // Pick a new random destination
        destPos = RandomPos();
        
        // Reset t so the lerp starts fresh
        t = 0f;
    }

    Vector2 RandomPos()
    {
        // Return a random position within screen bounds
        return new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f));
    }
}

