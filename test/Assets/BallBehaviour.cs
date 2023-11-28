using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform sprite;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vtmp = new Vector2(Input.GetAxis("Horizontal"),0);

        if(vtmp.x<0f)
        {
            sprite.localScale = new Vector3(1, 1, 1);
        }
        if (vtmp.x > 0f)
        {
            sprite.localScale = new Vector3(-1, 1, 1);
        }
        rb.AddForce(vtmp * Time.deltaTime * 500);

        if(Input.GetButtonDown("Jump") && rb.velocity.y==0)
        {
            rb.AddForce(Vector2.up * 350);
        }
    }
}
