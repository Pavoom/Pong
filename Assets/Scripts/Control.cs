using UnityEngine;

public class Control : MonoBehaviour
{
    Transform posn;
    public float speed = 5f;
    public float movement = 0f;
    public KeyCode upkey = KeyCode.UpArrow;
    public KeyCode downkey = KeyCode.DownArrow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         posn = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        movement = 0f;

        if (Input.GetKey(upkey))
        {
            movement = 1f;
        }
        else if (Input.GetKey(downkey))
        {
            movement = -1f;
        }
        posn.position += new Vector3(0, movement * speed * Time.deltaTime, 0);
    }
}
