using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class PlayerEndless : MonoBehaviour
    {   
        public bool posDown = true;
       


        public IEnumerator changeXDirection(int direction)
        { 
            float timePassed = 0;

            while (timePassed < 1)
            {
                transform.Translate(direction * 0.5f * Time.deltaTime, 0, 0);

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
                transform.Translate(0, direction * 300f * Time.deltaTime, 0);
                timePassed += Time.deltaTime;

                yield return null;
            }
        }
    }
 }


