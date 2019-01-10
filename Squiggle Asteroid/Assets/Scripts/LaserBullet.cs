using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    
    public float MovementSpeed;

    // Spawn a prefab and apply a force to it.
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            transform.position.y + MovementSpeed * Time.deltaTime);

        if (transform.position.y > 5.5f)
        {
            gameObject.SetActive(false);
        }
    }

    //If the prefab conect with a object with a tag "Asteroid" it apply 50 damage and set the prefab inactive.
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Asteroid enemy = hitInfo.GetComponent<Asteroid>();
        if (enemy != null)
        {
            enemy.TakeDamage(50);
        }
        gameObject.SetActive(false);
    }

}
