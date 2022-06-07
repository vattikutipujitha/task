using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision_sphere : MonoBehaviour
{
    Rigidbody rg;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "sphere")
        {
            if (rg.velocity.magnitude < collision.rigidbody.velocity.magnitude)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
