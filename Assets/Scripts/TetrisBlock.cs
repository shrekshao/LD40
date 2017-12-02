using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour {

    public enum BlockType { Falling = 0, Tank };

    public BlockType blockType = BlockType.Falling;

    TetrisPart parentPart;

    GameObject childWeapon = null;

	// Use this for initialization
	void Start () {
        parentPart = transform.parent.GetComponent<TetrisPart>();

        if (transform.childCount > 0)
        {
            childWeapon = transform.GetChild(0).gameObject;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnCollisionEnter(Collision c)
    //{

    //}

    void OnTriggerEnter(Collider c)
    {
        if (blockType == BlockType.Falling)
        {
            Debug.Log("Falls on Tank");

            //TetrisBlock hitTankBlock = c.gameObject.GetComponent<TetrisBlock>();

            if (parentPart != null)
            {
                parentPart.Assemble(
                    c.gameObject.transform.parent.GetComponent<TetrisTank>()
                );
            }
            
            //transform.parent.SendMessage("Assemble");
        }
        
    }

    public void TransformToTankBlock(Rigidbody tankRigidBody)
    {
        blockType = BlockType.Tank;
        GetComponent<Collider>().isTrigger = false;

        if (childWeapon != null)
        {
            childWeapon.SendMessage("Activate", tankRigidBody);
        }
    }
}
