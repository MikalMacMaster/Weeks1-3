//WEEK ONE STUFF:

using UnityEngine;

public class CircleMover : MonoBehaviour
{
    public float speedX = 0.2f;
    public float speedY = 0.2f;

    void Start()
    {
       



    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speedX, speedY, 0) * Time.deltaTime;

        //right side
        if (transform.position.x > 10)
        {
            speedX = -speedX;
        }
        //left side
        if (transform.position.x < -10)
        {
            speedX = -speedX;
        }
        //top side
        if (transform.position.y > 5)
        { 
            speedY = -speedY;
        }
        //bottom
        if (transform.position.y < -5)
        {
            speedY = -speedY;
        }
    }   
}
