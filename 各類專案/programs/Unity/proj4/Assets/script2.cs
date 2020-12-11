//using UnityEngine;
//using System.Collections;

//public class script2 : MonoBehaviour {

//    // Use this for initialization
//    void Start () {
	
//    }
	
//    // Update is called once per frame
//    void Update () {
	
//    }
//}
using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
public class script2 : MonoBehaviour
{
  /// <summary>
  /// 1 - The speed of the ship
  /// </summary>
  public Vector2 speed = new Vector2(50, 50);

  // 2 - Store the movement
  private Vector2 movement;

  void Update()
  {
    // 3 - Retrieve axis information
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");

    // 4 - Movement per direction
    movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);
      
  }

  void FixedUpdate()
  {
    // 5 - Move the game object
    rigidbody2D.velocity = movement;
  }
}