using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Player : MonoBehaviour
    {
        public GameObject player;
        private float moveSpeed;
        public float currentPos;
        public bool posDown = true;
        public bool move = true;
        Vector3 startPos;

        public GameObject bigBossTrigger;
        private Excercise exercise;

        private void Start()
        {
            exercise = FindObjectOfType<Excercise>();
        }

        void Update()
        {
            if (move == true)
            {
                transform.Translate((new Vector3(1, 0, 0)) * PlayerPrefs.GetInt("speed") * Time.deltaTime);
                this.currentPos = player.transform.position.y;
            }

        }

        //Trigger of the Boss Section
        private void OnTriggerEnter2D(Collider2D playerCollider)
        {
            if (playerCollider.tag == "BigBossTrigger")
            {
                exercise.bigboss = true;
                move = false;
                Destroy(bigBossTrigger);
            }
        }

        //Set the movement speed
        public void setSpeedMovement(float number)
        {
            this.moveSpeed = number;
        }

        //Change the X direction of the player
        public IEnumerator changeXDirection(int direction)
        { 
            float timePassed = 0;

            while (timePassed < 1)
            {
                player.transform.Translate(direction * 0.5f * Time.deltaTime, 0, 0);

                timePassed += Time.deltaTime;

                //Animation boom

                yield return null;
            }
        }

        public IEnumerator changeYDirection(int direction)
        {
            float timePassed = 0;

            while (timePassed < 1.5)
            {
                player.transform.Translate(0, direction * 300f * Time.deltaTime, 0);
                timePassed += Time.deltaTime;

                yield return null;
            }
        }
    }
}