
using UnityEngine;

public class PufferFish : MonoBehaviour
{
    public float pufferRange;
    public Vector3 normalSize = Vector3.one;
    public Vector3 inflatedScale = new Vector3(2f, 2f, 1f);
    public float inflationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = 0;

        float distance = Vector3.Distance(transform.position, mousePosition);

        Vector3 endSize;

        if(distance < pufferRange)
        {
            endSize = inflatedScale;
        }
        else
        {
            endSize = normalSize;
        }

        transform.localScale = Vector3.Lerp(transform.localScale, endSize, inflationSpeed * Time.deltaTime);
    }
}
