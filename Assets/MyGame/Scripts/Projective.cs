using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projective : MonoBehaviour
{
    public int damage = 5;
    public Vector2 fore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("Enemy"))
            
        {
            BehemothAI behemothAI = collision.GetComponent<BehemothAI>();
            if (behemothAI != null)
            {
                behemothAI.TakeDamage(damage, fore, gameObject);
                Destroy(gameObject);
            }
                
        }
    }
}
