using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb2d;
    public GameObject gameOver, Restart, Exit;

    [SerializeField]
    private float speed;

    //Put the buttons in inactive mode and give a referance to Rigidbody2D.
    void Start()
    {
        gameOver.SetActive(false);
        Restart.SetActive(false);
        Exit.SetActive(false);

        rb2d = GetComponent<Rigidbody2D>();
    }

    //Limits the horizontal movement.
    private void LateUpdate()
    {
        if (transform.position.x > 5.7)
        {
            transform.position = new Vector3(5.7f, transform.position.y);
        }

        if (transform.position.x <-5.7)
        {
            transform.position = new Vector3(-5.7f, transform.position.y);
        }
    }

    //Gives acess to horizontal movement.
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
    }
    
    //Links the rigidbody with speed and applys force.
    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }

    //Check for contact and if any turn teh bottons active.
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Asteroid"))
        {
            gameOver.SetActive(true);
            Restart.SetActive(true);
            Exit.SetActive(true);
        }
    }



}
