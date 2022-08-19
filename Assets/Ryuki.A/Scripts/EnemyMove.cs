using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Vector2 initPosition;
    Vector2 newPosition;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        initPosition = this.transform.position;
        rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        newPosition = new Vector3(initPosition.x + Mathf.Sin(Time.time), initPosition.y);
        //this.GetComponent<Rigidbody>().MovePosition(newPosition);
        rb.MovePosition(newPosition);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tag = collision.gameObject.tag;
        if (tag == "kunai" || tag == "shuriken" || tag == "Katana")
        {
            Destroy(gameObject);
        }
    }
}
