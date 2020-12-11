using UnityEngine;

//using System.Collections;

//using System;
/// <summary>
/// Player controller and behavior
/// </summary>
public class TestScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
    // Use this for initialization
    private Vector2 movement;
    void Start()
    {

        //i = 0;

        //MessageBox.Show("hello world");
    }


    // Update is called once per frame

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);

        


    }
    void FixedUpdate()
    {

//2D
        rigidbody2D.velocity = movement;
    }

}
//using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
//public class PlayerScript : MonoBehaviour
//{
//  /// <summary>
//  /// 1 - The speed of the ship
//  /// </summary>
//  public Vector2 speed = new Vector2(50, 50);

//  // 2 - Store the movement
//  private Vector2 movement;

//  void Update()
//  {
//    // 3 - Retrieve axis information
//    float inputX = Input.GetAxis("Horizontal");
//    float inputY = Input.GetAxis("Vertical");

//    // 4 - Movement per direction
//    movement = new Vector2(
//      speed.x * inputX,
//      speed.y * inputY);

//  }

//  void FixedUpdate()
//  {
//    // 5 - Move the game object
//    rigidbody2D.velocity = movement;
//  }
//}