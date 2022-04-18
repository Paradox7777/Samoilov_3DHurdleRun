using UnityEngine;

namespace Runner
{
    public class Bomb : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                GameObject.FindGameObjectWithTag("Player").SetActive(false);
            }
        }
    }

}

