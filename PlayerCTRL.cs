using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCTRL : MonoBehaviour
{
    [SerializeField]
    private float speedmove = 0.0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float hAxis = Input.GetAxis("Horizontal");
            Vector3 moveDir = new Vector3(hAxis, 0, 0);
            rb.velocity = moveDir * speedmove * Time.fixedDeltaTime;
        }
    }
}
