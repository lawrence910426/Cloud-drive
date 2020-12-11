using UnityEngine;
using System.Collections;

public class bulletMovScript : MonoBehaviour
{
    public int speedX = 10;//you should change float to int
    public int speedY = 0;
    public Vector2 direction = new Vector2(1, 0);


    private Vector2 movement;
    // Use this for initialization
    void Start()
    {
        movement = rigidbody2D.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(
            direction.x * speedX
            , direction.y * speedY);
    }
    void FixedUpdate()
    {
        rigidbody2D.velocity = movement;
    }
}
