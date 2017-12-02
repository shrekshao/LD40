using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour {

    float fallingSpeed;
    float movingSpeed = 1.0f;

    float fallingSpeedScale = 1.0f;

    const float slowFallingSpeed = 0.5f;
    const float fastFallingSpeed = 5.0f;

	// Use this for initialization
	void Start () {
        fallingSpeed = slowFallingSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.down * fallingSpeed * fallingSpeedScale * Time.deltaTime;


        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            MoveX(-movingSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            MoveX(movingSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            MoveZ(movingSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            MoveZ(-movingSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(90.0f, 0.0f, 0.0f);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetFallingSpeedScale(fastFallingSpeed);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            SetFallingSpeedScale(slowFallingSpeed);
        }
    }
    

    public void MoveX(float s)
    {
        transform.position += Vector3.right * s;
    }

    public void MoveZ(float s)
    {
        transform.position += Vector3.forward * s;
    }

    public void SetFallingSpeedScale(float s)
    {
        fallingSpeedScale = s;
    }
}
