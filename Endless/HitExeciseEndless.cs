using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class HitExeciseEndless : MonoBehaviour
    {
        private bool hit = false;
        GameControl gameControl;

        void Awake()
        {
            gameControl = FindObjectOfType<GameControl>();
        }

        void Update()
        {
            if (hit)
            {
                gameControl.GameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                hitObstacle();
                gameControl.WQuestion = gameControl.ex.GetComponent<ExerciseEndless>().exercise.ToString();
                gameControl.WAnswer = gameControl.ex.GetComponent<ExerciseEndless>().answer.ToString();
                gameControl.Equation = gameControl.WQuestion + " = " + gameControl.WAnswer;
                gameControl.Hit = true;
                
      
            }

            if (other.tag == "Bullet")
            {
                GameObject explosion = (GameObject)Instantiate(gameControl.ExplosionPrefab, transform.position, transform.rotation); 
                Destroy(explosion, 0.5f);
                Destroy(this. gameObject);
                
                // levelManager.correctAnswer = false;
            }
        }

        public void hitObstacle()
        {   
            hit = true;        
        }
    }
}

