using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrap : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Thrust = 400.0f;
    public float m_Push = 5f;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, m_Thrust * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {
            Vector3 push = collision.contacts[0].normal;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(-push * m_Push, ForceMode.Impulse);
        }
    }
}
