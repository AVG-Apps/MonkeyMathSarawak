using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Live : MonoBehaviour
    {
        public void loseLife()
        {
            Destroy(gameObject, -1f);
        }
    }
}

