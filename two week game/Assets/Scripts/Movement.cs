using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed = 3;

    public const string right = "right";
    public const string left = "left";

    string buttonPressed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            buttonPressed = right;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            buttonPressed = left;
        }
    }
    private void FixedUpdate()
    {
        if(buttonPressed == right)
        {
            rb.AddForce(new Vector2(moveSpeed, 0), ForceMode2D.Impulse);
        }
        else if(buttonPressed == left)
        {
            rb.AddForce(new Vector2(-moveSpeed, 0), ForceMode2D.Impulse);
        }
    }
}
