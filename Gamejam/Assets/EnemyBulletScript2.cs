using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript2 : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * -speed;
        Destroy(gameObject,4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
