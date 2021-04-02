using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThrow : MonoBehaviour
{

    public Rigidbody thisRigidBody;
    private Vector3 startposition;
    public Vector3 ballForce;
    public bool mouseClick = false;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidBody = GameObject.FindGameObjectWithTag("ball").GetComponent<Rigidbody>();
        startposition = this.thisRigidBody.transform.position;
        ballForce = new Vector3(0f, 60f, 230f);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0) && mouseClick == false)
            {
                thisRigidBody.AddForce(ballForce);
                mouseClick = true;
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        Reset();
    }

    public void Reset()
    {
        thisRigidBody.AddForce(-ballForce);
        transform.position = startposition;
        mouseClick = false;
    }
}
