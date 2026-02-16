using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float amplitude = 2f;
    public float speed = 2f;
    public float sizeAmount = 0.5f;

    private Vector3 startPos;
    private Vector3 startScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed);

       
        transform.position = startPos + new Vector3(0, offset * amplitude, 0);

        transform.localScale = startScale + new Vector3(offset * sizeAmount, offset * sizeAmount, 0);
    }
}
