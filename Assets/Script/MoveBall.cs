using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

    private Rigidbody rigid;
    private float moveSpeed;
	// Use this for initialization
	void Start () {
        moveSpeed = 5.0f;
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigid.AddForce(movement*moveSpeed);
        Debug.Log("Move!");
    }
}
