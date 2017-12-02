using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPartController : MonoBehaviour {

    float movingSpeed = 1.0f;
    public Falling curFallingPart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (curFallingPart != null)
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                curFallingPart.MoveX(-movingSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                curFallingPart.MoveX(movingSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                curFallingPart.MoveZ(movingSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                curFallingPart.MoveZ(-movingSpeed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                curFallingPart.SetFallingSpeedScale(5.0f);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                curFallingPart.SetFallingSpeedScale(1.0f);
            }
        }
	}
}
