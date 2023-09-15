using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControler : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (moveX == 0 && moveZ == 0) return;
        
        rb.velocity = new Vector3(moveX, 0, moveZ) * speed;

    }

    public float GetSpeed() => speed;
}
