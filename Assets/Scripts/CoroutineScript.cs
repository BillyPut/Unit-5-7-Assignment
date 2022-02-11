using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineScript : MonoBehaviour
{
    SpriteRenderer sr;
    private Rigidbody2D rb;
    int i;
    int l;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        StartCoroutine(MovingCoroutine());

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MovingCoroutine()
    {
        Vector2 velocity = rb.velocity;

        velocity.x = 0;

        for(i = 0; i < 5; i++)
        {
            

            velocity.x = -5f;

           

            rb.velocity = new Vector3(velocity.x, 0f, 0f);

            yield return new WaitForSeconds(0.5f);


            velocity.x = 5f;

           

            rb.velocity = new Vector3(velocity.x, 0f, 0f);

            yield return new WaitForSeconds(0.5f);

        }

        StartCoroutine(ColorFadeCoroutine());

    }

    IEnumerator ColorFadeCoroutine()
    {

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        for (l = 0; l < 20; l++)
        {
            sr.color = new Color(100f, 0f, 0f, 100f);

            yield return new WaitForSeconds(0.5f);

            sr.color = new Color(0f, 0f, 0f, 0f);

            yield return new WaitForSeconds(0.5f);
        }

       


    }


}
