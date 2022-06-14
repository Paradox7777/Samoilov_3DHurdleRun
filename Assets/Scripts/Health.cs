using UnityEngine;

namespace Runner
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxHealth = 10f;
        private float curHealth;
        
        private void Awake()
        {
            curHealth = maxHealth;
        }

        public void Hit(float damage)
        {
            curHealth -= damage;
            if(curHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }

    }
}
