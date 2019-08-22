using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace monkeyMath
{

    public class Excercise : MonoBehaviour
    {
        #region Attribute
        public string exercise;
        public int answer;
        public bool posDown;
        public bool bigboss = false;
        public int levelExercise;

        private LevelManager levelManager;

        private Vector3 updatedPos;
        int firstNumber = 1;
        int secondNumber = 1;

        public float EPSILON { get; private set; }
        #endregion

        void Awake()
        {
            levelManager = FindObjectOfType<LevelManager>();
        }

        // private void OnTriggerEnter2D(Collider2D other)
        // {
        //     if (other.tag == "Player")
        //     {
        //         nextExercise();
        //     }
        // }

        public void setAdditionExercise()
        {
            int position = UnityEngine.Random.Range(0, 1);

            if (position == 1)
            {
                firstNumber = getLevelExercise();
                secondNumber = UnityEngine.Random.Range(0, 9);
            }

            if (position == 0)
            {
                firstNumber = UnityEngine.Random.Range(0, 9);
                secondNumber = getLevelExercise();
            }

            this.answer = firstNumber + secondNumber;
            this.exercise = firstNumber + "+" + secondNumber;
        }

        public void setAdditionExercise(int level)
        {
            firstNumber = UnityEngine.Random.Range(0, 9);
            secondNumber = level;
            
            this.answer = firstNumber + secondNumber;
            this.exercise = firstNumber + "+" + secondNumber;
        }

        public void setSubtractionExercise()
        {
            firstNumber = UnityEngine.Random.Range(0, 9) + getLevelExercise();
            secondNumber = getLevelExercise();

            this.answer = firstNumber - secondNumber;
            this.exercise = firstNumber + "-" + secondNumber;
        }

        public void setSubtractionExercise(int level)
        {
            firstNumber = UnityEngine.Random.Range(0, 9) + level;
            secondNumber = level;

            this.answer = firstNumber - secondNumber;
            this.exercise = firstNumber + "-" + secondNumber;
        }

        public void setMultiplicationExercise()
        {
            firstNumber = UnityEngine.Random.Range(0, 9);
            secondNumber = getLevelExercise();

            this.answer = firstNumber * secondNumber;
            this.exercise = firstNumber + "×" + secondNumber;
        }

        public void setMultiplicationExercise(int level)
        {
            firstNumber = UnityEngine.Random.Range(0, 9);
            secondNumber = level;

            this.answer = firstNumber * secondNumber;
            this.exercise = firstNumber + "×" + secondNumber;
        }

        public void setDivisionExercise()
        {
            firstNumber = UnityEngine.Random.Range(0, 9) * getLevelExercise();
            secondNumber = getLevelExercise();

            try{
                this.answer = firstNumber / secondNumber;
            }catch (DivideByZeroException)
            {
                Debug.Log(secondNumber);
            }
            
            this.exercise = firstNumber + "÷" + secondNumber;
        }

        public void setDivisionExercise(int level)
        {
            firstNumber = UnityEngine.Random.Range(0, 9) * level;
            secondNumber = level;

            try{
                this.answer = firstNumber / secondNumber;
            }catch (DivideByZeroException)
            {
                Debug.Log(secondNumber);
            }
            
            this.exercise = firstNumber + "÷" + secondNumber;
        }


        public void changePosition(Excercise exercise, int changeValue)
        {
            exercise.transform.Translate(0, changeValue * 500, 0);
        }


        public void nextExercise()
        {
            if (bigboss == false)
            {
                levelManager.currentExercise += 1;
                levelManager.checkExercisePosition();
               
            }
            else
            {
                levelManager.bossCurrentExercise += 1;
            }
        }

        public int getLevelExercise()
        {
            return PlayerPrefs.GetInt("MathLevelNumber");
        }
    }
}