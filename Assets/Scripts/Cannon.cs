using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {


    public Rigidbody m_rigidBodyTank;

	// Use this for initialization
	void Start () {
        StartCoroutine(Fire());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Fire()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);

            m_rigidBodyTank.AddForceAtPosition(-transform.forward, transform.position, ForceMode.Impulse);
        }
       
    }
}
