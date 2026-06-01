using UnityEngine;

public class Bubbles : MonoBehaviour
{
    public float speed;     // how fast the bubble rises
    public float top; // where it resets to bottom
    public float bottom;        // where it spawns after reaching top

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;      // move up each frame

        if (transform.position.y > top)
        {
            transform.position = new Vector3(transform.position.x, bottom, transform.position.z);       // teleport back to bottom 
        }
    }
}

// Asset Links: 
// Jellyfish: https://elthen.itch.io/2d-pixel-art-jellyfish-sprites 
// Background: https://free-game-assets.itch.io/free-underwater-world-pixel-art-backgrounds
// Fish, Pufferfish, Crab: https://pixelgnome.itch.io/fish/download/eyJleHBpcmVzIjoxNzgwMjYzMDIwLCJpZCI6MzM0MDE1Nn0%3d%2excAFPLiprZJKNh4KnU3AlQyjYnE%3d
// Bubble: https://slowdevelopment.itch.io/bubble/download/eyJleHBpcmVzIjoxNzgwMjYzMDk0LCJpZCI6MzQ4NjU0MH0%3d%2eMAjenVUP0gtM5JhIsJIPgqkxV2g%3d


