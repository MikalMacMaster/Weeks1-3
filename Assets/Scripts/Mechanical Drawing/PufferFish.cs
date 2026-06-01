
using UnityEngine;

public class PufferFish : MonoBehaviour
{
    public float pufferRange;       // distance from mouse that initiates puff
    public Vector3 normalSize = Vector3.one;        // default size (1, 1, 1)
    public Vector3 inflatedScale = new Vector3(2f, 2f, 1f);     // puffed up size
    public float inflationSpeed;        // how fast it lerps between sizes
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);        // convert mouse screen coords to world coords

        mousePosition.z = 0; // keep 2d

        float distance = Vector3.Distance(transform.position, mousePosition);       // how far the fish is from the mouse

        Vector3 endSize;        // target size 

        if(distance < pufferRange)
        {
            endSize = inflatedScale;        // mouse is close, grow
        }
        else
        {
            endSize = normalSize;       // mouse is far, shrink back down
        }

        transform.localScale = Vector3.Lerp(transform.localScale, endSize, inflationSpeed * Time.deltaTime);        // interpolate towards target size
    }
}

// Asset Links: 
// Jellyfish: https://elthen.itch.io/2d-pixel-art-jellyfish-sprites 
// Background: https://free-game-assets.itch.io/free-underwater-world-pixel-art-backgrounds
// Fish, Pufferfish, Crab: https://pixelgnome.itch.io/fish/download/eyJleHBpcmVzIjoxNzgwMjYzMDIwLCJpZCI6MzM0MDE1Nn0%3d%2excAFPLiprZJKNh4KnU3AlQyjYnE%3d
// Bubble: https://slowdevelopment.itch.io/bubble/download/eyJleHBpcmVzIjoxNzgwMjYzMDk0LCJpZCI6MzQ4NjU0MH0%3d%2eMAjenVUP0gtM5JhIsJIPgqkxV2g%3d


