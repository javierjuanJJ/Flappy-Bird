using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeatingbackground : MonoBehaviour
{
    private BoxCollider2D rigidbody;
    private float groundhorizontal;
    private void Awake()
    {
        rigidbody = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        groundhorizontal = rigidbody.size.x;
    }
    void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundhorizontal * 2);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundhorizontal)
        {
            RepositionBackground();
        }
    }
}
