using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float floatAmount = 0.5f;

    public AnimationCurve pulseCurve;
    public float pulseSpeed = 1f;
    public float pulseAmount = 0.3f;

    private Vector3 startPosition;
    private Vector3 startScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float floatY = Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        transform.position = new Vector3(startPosition.x, startPosition.y + floatY, startPosition.z);

        float curveValue = pulseCurve.Evaluate(Time.time * pulseSpeed);

        transform.localScale = startScale + new Vector3(curveValue * pulseAmount, curveValue * pulseAmount, 0);
    }
}
