using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = new Vector2(GameController.instance.scrollSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver)
        {
            rigidbody.velocity = Vector2.zero;
        }
    }
}
