using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectFrostBolt : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        Destroy(this.gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Target target = hitinfo.GetComponent<Target>();
        if (target != null)
        {
            target.TakeDamage(100);
        }
        Destroy(gameObject);
        GameObject clone = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(clone, 0.75f);
    }

}
