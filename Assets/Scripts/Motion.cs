using Unity.VisualScripting;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float xSpeed=0, ySpeed=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(xSpeed, ySpeed);
    }

}
