using UnityEngine;

public class Crab : MonoBehaviour
{
    float timer = 0;        // tracks time for the shuffle sin wave
    public float speed;         // left/right movement speed
    public float leftEdge;      // x position where it turns right
    public float rightEdge;     // x position where it turns left
    public float shuffleAmount = 0.5f;      // how wide the left/right shuffle is
    public float shuffleSpeed = 8f;        // how fast the shuffle cycles

    private int direction = 1;      // 1 = going right, -1 = going left
    private float startX;       // tracks the x position the shuffle offsets from

    void Start()
    {
        startX = transform.position.x;      // starting x position
    }

    void Update()
    {
        startX += direction * speed * Time.deltaTime;       // move position in current direction 
        timer += Time.deltaTime;        // timer

        float shuffleOffset = Mathf.Sin(timer * shuffleSpeed) * shuffleAmount;      // sin wave for side shuffle 
        transform.position = new Vector3(startX + shuffleOffset, transform.position.y, transform.position.z);       // shuffle on top of normal movement

        if (transform.position.x >= rightEdge)
        {
            direction = -1;     // hit right wall turn left
            transform.eulerAngles = new Vector3(0, 180, 0);     // rotate to face left
        }

        if (transform.position.x <= leftEdge)
        {
            direction = 1;      // hit left wall turn right
            transform.eulerAngles = new Vector3(0, 0, 0);       // rotate to face right
        }
    }
}

// Asset Links: 
// Jellyfish: https://elthen.itch.io/2d-pixel-art-jellyfish-sprites 
// Background: https://free-game-assets.itch.io/free-underwater-world-pixel-art-backgrounds
// Fish, Pufferfish, Crab: https://pixelgnome.itch.io/fish/download/eyJleHBpcmVzIjoxNzgwMjYzMDIwLCJpZCI6MzM0MDE1Nn0%3d%2excAFPLiprZJKNh4KnU3AlQyjYnE%3d
// Bubble: https://slowdevelopment.itch.io/bubble/download/eyJleHBpcmVzIjoxNzgwMjYzMDk0LCJpZCI6MzQ4NjU0MH0%3d%2eMAjenVUP0gtM5JhIsJIPgqkxV2g%3d

