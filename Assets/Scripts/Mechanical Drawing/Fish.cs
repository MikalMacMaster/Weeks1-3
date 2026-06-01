using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;     // left/right movement speed
    public float leftEdge;      // x position where it turns right
    public float rightEdge;     // x position where it turns left

    private int direction = 1;      // 1 = going right, -1 = going left

    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;       // move along the x axis each frame, using direction to control which way and Time.deltaTime to keep speed consistent

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

