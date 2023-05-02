using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundry.leftSide){ //this line is for the level boundary. it means we cannot move beyond this the player
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
         if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundry.rightSide){ //this line is for the level boundary. it means we cannot move beyond this the player
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }

        }
    }
}
