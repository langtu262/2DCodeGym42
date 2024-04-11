using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projective : MonoBehaviour
{
    public int damage = 5;
    public Vector2 fore;
    [SerializeField] GameObject Fxprojective;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null && collision.CompareTag("Enemy"))
            
        {
            BehemothAI behemothAI = collision.GetComponent<BehemothAI>();
            if (behemothAI != null)
            {
                Instantiate(Fxprojective,transform.position, Quaternion.identity);
                behemothAI.TakeDamage(damage, fore, gameObject);
                Destroy(gameObject);
            }
                
        }
    }
}
