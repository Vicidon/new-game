using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidScript : MonoBehaviour
{
    public GameObject gameOver, Restart, Exit;
    
    // Starts the game with the mentioned gameobjects in inactive mode.
    void Start()
    {
        gameOver.SetActive(false);
        Restart.SetActive(false);
        Exit.SetActive(false);
    }

    
    // Check for contact between objects and therefore activate the buttons if there is a contact.
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
