using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonFallScript : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            Vector2 velocity = rb.velocity;

            transform.position = new Vector3(Random.Range(-7, 7), 23f, -1f);
            

            rb.velocity = new Vector3(0f, 0f, 0f);
        }


    }

}
