using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Thrust = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(-Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));
        m_Rigidbody.AddForce(movement * m_Thrust);
    }
}
