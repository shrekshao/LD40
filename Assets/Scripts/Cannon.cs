using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {


    Rigidbody m_rigidBodyTank;

    private IEnumerator coroutine;


    // Use this for initialization
    void Start () {
        
    }
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    public void Activate(Rigidbody rigidbodyTank)
    {
        m_rigidBodyTank = rigidbodyTank;
        coroutine = Fire();
        StartCoroutine(coroutine);
    }

    public void Deactivate()
    {
        StopCoroutine(coroutine);
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
