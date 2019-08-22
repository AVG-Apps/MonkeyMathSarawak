using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Weapon : MonoBehaviour
    {
        public Transform firepoint;
        public GameObject bulletPrefab;

        public void shoot()
        { 
            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        }
    }
}
