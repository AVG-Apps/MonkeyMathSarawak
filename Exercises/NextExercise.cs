using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class NextExercise : MonoBehaviour
    {
        #region Attribute
        private Excercise exercise;
        LevelManager levelManager;
        #endregion

        void Awake()
        {
            exercise = FindObjectOfType<Excercise>();
            levelManager = FindObjectOfType<LevelManager>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                exercise.nextExercise();
            }
        }
    }
}