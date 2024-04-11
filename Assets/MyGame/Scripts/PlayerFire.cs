using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public Transform pointFire;
    public Rigidbody2D rb;
    public float projectiveFore = 20f;
    public GameObject projectivePrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1"))
        {
            GameObject projevtive = Instantiate(projectivePrefabs, pointFire.position, Quaternion.identity );
            rb = projevtive.GetComponent<Rigidbody2D>();
            if(transform.localScale.x==1)
            {
                rb.AddForce(pointFire.right * projectiveFore,ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(-pointFire.right * projectiveFore, ForceMode2D.Impulse);
            }
        }
    }
}
