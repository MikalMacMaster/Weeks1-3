using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    public float floatSpeed = 1f;       // how fast the bob up/down cycles
    public float floatAmount = 0.5f;        // how far up/down it goes

    public AnimationCurve pulseCurve;       // shape of the pulse made in inspector
    public float pulseSpeed = 1f;       // how fast it pulses
    public float pulseAmount = 0.3f;        // how much it grows when pulsing

    private Vector3 startPosition;      // saves start position to keep bobbing reletive 
    private Vector3 startScale;     // saves origional size so pulse adds on top
    private float timer;        // tracks time
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;     //position at spawn
        startScale = transform.localScale;      // size at spawn
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;        // add time since last frame
        float floatY = Mathf.Sin(timer * floatSpeed) * floatAmount;     // sin wave for up/down value

        transform.position = new Vector3(startPosition.x, startPosition.y + floatY, startPosition.z);       // apply bob, keep x and z locked

        float timeLoop = Mathf.Repeat(timer * pulseSpeed, 1f);      // loops so curve replays
        float curveValue = pulseCurve.Evaluate(timeLoop);     // current loop position

        transform.localScale = startScale + new Vector3(curveValue * pulseAmount, curveValue * pulseAmount, 0);     //grow x and y by curve, keep z at 0
    }
}

// Asset Links: 
// Jellyfish: https://elthen.itch.io/2d-pixel-art-jellyfish-sprites 
// Background: https://free-game-assets.itch.io/free-underwater-world-pixel-art-backgrounds
// Fish, Pufferfish, Crab: https://pixelgnome.itch.io/fish/download/eyJleHBpcmVzIjoxNzgwMjYzMDIwLCJpZCI6MzM0MDE1Nn0%3d%2excAFPLiprZJKNh4KnU3AlQyjYnE%3d
// Bubble: https://slowdevelopment.itch.io/bubble/download/eyJleHBpcmVzIjoxNzgwMjYzMDk0LCJpZCI6MzQ4NjU0MH0%3d%2eMAjenVUP0gtM5JhIsJIPgqkxV2g%3d

