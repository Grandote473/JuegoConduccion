using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviCarPlayer : MonoBehaviour
{
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;
    private float movee;
    public static bool PointerDown = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movee = moveSpeed;
    }
    void Update()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
        float hAxis = move.x;
        float vAxis = move.y;
        float zAxis = Mathf.Atan2 (hAxis, vAxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3 (0, 0, -zAxis);
    }
    private void FixedUpdate()
    {
        if (PointerDown)
        {
            rb.velocity = Vector3.zero;
        }
        else
        {
            rb.MovePosition(rb.position + move * movee * Time.fixedDeltaTime);
        }
    }
    public void Frenar()
    {
        movee = 0;
    }
    public void Arrancar()
    {
        movee = moveSpeed;
    }    
}
