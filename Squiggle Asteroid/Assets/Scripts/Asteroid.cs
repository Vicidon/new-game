using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int solidity = 100;
    
    //If the solidity of the object is 0 or less it dies(inactive).
    public void TakeDamage(int damage)
    {
        solidity -= damage;
        if (solidity <= 0)
        {
            Die();
        }
    }

    //Set the object in inactive.
    void Die()
    {        
        gameObject.SetActive(false);
    }

    
}
