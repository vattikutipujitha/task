using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision_cube : MonoBehaviour
{
    Rigidbody rg;
    public SpawnManager spawnManager;
    private int cubeCnt;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "cube")
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
