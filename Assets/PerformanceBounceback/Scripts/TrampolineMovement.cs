using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineMovement : MonoBehaviour {

    public Vector3 direction = Vector3.right;
    public float moveSpeed = 3.5f;
    public float moveTime = 3f;
    private float time;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{
		rb.MovePosition(transform.position + direction * Time.deltaTime * moveSpeed);
	}


	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time > moveTime)
        {
            time = 0;
            direction = direction * -1;
        }
	}
}
