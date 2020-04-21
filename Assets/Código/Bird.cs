using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private bool isDead;

    private Rigidbody2D rigidbody;
    private Animator animator;
    public GameController gameController;
    public float upForce = 200f;
    private static int score;
    public Text Texto;
    private void Awake()
    {
        
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Texto.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("volando");
                rigidbody.velocity = Vector2.zero;
                rigidbody.AddForce(new Vector2(0,upForce));
            }
        }
        else
        {
            animator.SetTrigger("muerte");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.tag.ToLower().Equals("Player"))
        {
            GameController.instance.BirdDie();
            animator.SetTrigger("muerte");
            isDead = true;
            rigidbody.velocity = Vector2.zero;
        }
        else
        {
            
        }
       
    }
}
