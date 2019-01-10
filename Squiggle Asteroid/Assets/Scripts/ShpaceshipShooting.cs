using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpaceshipShooting : MonoBehaviour
{
    public GameObject LaserPrefab;
    public GameObject[] LaserBulletPool;
    public int MaxLaserBullets;
    
   
    // Creates a pool for the laser prefab with the prefab in it in inactive mode. 
    void Start()
    {
        LaserBulletPool = new GameObject[MaxLaserBullets];

        for (int i = 0; i < MaxLaserBullets; i++)
        {
            LaserBulletPool[i] = Instantiate(LaserPrefab);
            LaserBulletPool[i].SetActive(false);
        }
    }

    // If there are too many active prefabs it set the first one inactive.
    private GameObject GetSpareBullet()
    {
        for (int i = 0; i < MaxLaserBullets; i++)
        {
            if (LaserBulletPool[i].activeSelf == false)
            {
                return LaserBulletPool[i];
            }
        }

        return null;
    }

    // It fires the lasers.
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            GameObject bullet = GetSpareBullet();

           if (bullet != null)
           {
                bullet.SetActive(true);
                bullet.transform.position = transform.position;
           }
        }
    }

}
