using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class ExerciseEndless : MonoBehaviour
    {
        public string exercise;
        public int answer;
        public bool posDown;

        private Vector3 updatedPos;
        int firstNumber = 1;
        int secondNumber = 1;


        public void setAdditionExercise()
        {
            int position = UnityEngine.Random.Range(0, 1);

            if (position == 1)
            {
                firstNumber = UnityEngine.Random.Range(1, 10);
                secondNumber = UnityEngine.Random.Range(1, 9);
            }

            if (position == 0)
            {
                firstNumber = UnityEngine.Random.Range(1, 9);
                secondNumber = UnityEngine.Random.Range(1, 10);
            }

            this.answer = firstNumber + secondNumber;
            this.exercise = firstNumber + "+" + secondNumber;
        }

        public void setSubtractionExercise()
        {
            int a = UnityEngine.Random.Range(1, 10);
            firstNumber = UnityEngine.Random.Range(1, 9) + a;
            secondNumber = a;

            this.answer = firstNumber - secondNumber;
            this.exercise = firstNumber + "-" + secondNumber;
        }

        public void setMultiplicationExercise()
        {
            int a = UnityEngine.Random.Range(1, 10);
            firstNumber = UnityEngine.Random.Range(1, 9);
            secondNumber = a;

            this.answer = firstNumber * secondNumber;
            this.exercise = firstNumber + "×" + secondNumber;
        }

        public void setDivisionExercise()
        {
            int a = UnityEngine.Random.Range(1, 10);
            firstNumber = UnityEngine.Random.Range(1, 9) * a;
            secondNumber = a;

            try{
                this.answer = firstNumber / secondNumber;
            }catch (DivideByZeroException ex)
            {
                Debug.Log(secondNumber);
            }
            
            this.exercise = firstNumber + "÷" + secondNumber;
        }
    }
    

    
}

