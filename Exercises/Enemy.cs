using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Enemy : MonoBehaviour
    {
        public int health = 100;

        public GameObject deathEffect;

        private Excercise exercise;
        LevelManager levelManager;

        public bool isWin;

        private void Awake()
        {
            exercise = FindObjectOfType<Excercise>();
            levelManager = FindObjectOfType<LevelManager>();
        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0)
            {
               Die();
            }
    }

        void Die()
        {
         Instantiate(deathEffect, transform.position, Quaternion.identity);
         exercise.bigboss = false;
         isWin = true;
         levelManager.WellDonePanel.SetActive(true);
         Destroy(gameObject);
        }
    }
}
