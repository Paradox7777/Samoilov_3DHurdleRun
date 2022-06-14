using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Shoot
{
    [RequireComponent(typeof(FindTarget))]
    public class Shooting : MonoBehaviour
    {
        private FindTarget findTarget;

        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Bullet bulletPrefab;

        private float step = 1f;
        private float nextShot;

        private void Start()
        {
            findTarget = GetComponent<FindTarget>();
        }
        void Update()
        {
            if (!findTarget.HasTarget) { return; }

            if (!(Time.time > nextShot))
            {
                return;
            }
            nextShot = Time.time + step;

            Shoot();
        }

        private void Shoot()
        {
            var bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
