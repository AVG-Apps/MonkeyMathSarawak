using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class BulletEndless : MonoBehaviour
    {
        public float speed;
        public Rigidbody2D rb;
    
        void FixedUpdate()
        {
            rb.velocity = transform.right * Time.deltaTime * speed;
        }

        //Hit obstacle then destroy it
        void OnTriggerEnter2D(Collider2D hitInfo)
        {    
            if(hitInfo.tag == "Obstacle")
            {
                Destroy(gameObject);
            }
        }
    }
}


