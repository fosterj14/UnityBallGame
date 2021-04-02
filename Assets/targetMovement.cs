using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{

    static public float speed = .005f;
    public bool leftSideHit = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!leftSideHit)
        {
            transform.Translate(Vector3.left * speed);
        }
        if (leftSideHit)
        {
            transform.Translate(Vector3.right * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != GameObject.FindGameObjectWithTag("ball").GetComponent<SphereCollider>())
        {
            if (!leftSideHit)
            {
                leftSideHit = true;
            }
            else
            {
                leftSideHit = false;
            }
        }
    }

    static public float GetSpeed()
    {
        return speed;
    }
    static public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
