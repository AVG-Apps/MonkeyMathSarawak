using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Bullet : MonoBehaviour
    {
        public float speed;
        public Rigidbody2D rb;
        public int damage = 20;
        public AudioSource audioSource;

        private LevelManager levelManager;

        // Start is called before the first frame update
        void Awake()
        {
            levelManager = FindObjectOfType<LevelManager>();
        }
        void FixedUpdate()
        {
            rb.velocity = transform.right * Time.deltaTime * speed;
            // Debug.Log("Go Right Bullet");
        }

        void OnTriggerEnter2D(Collider2D hitInfo)
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();

            // if(enemy != null && levelManager.correctAnswer2)
            if(hitInfo.tag == "Obstacle")
            {
                // enemy.TakeDamage(damage);
                // levelManager.correctAnswer2 = false;
                audioSource.Play();
                Destroy(gameObject, 0.4f);
            }

            if(enemy != null && hitInfo.tag == "Boss")
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
            }
            
        }
    }
}
