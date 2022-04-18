
using UnityEngine;

namespace Runner.Shoot
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private float damage = 3f;

        void FixedUpdate()
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime;
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out Health health))
            {
                health.Hit(damage);
            }
            Destroy(gameObject);
        }
    }
}
