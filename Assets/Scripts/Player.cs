using UnityEngine;

namespace Runner
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float Speed;
        [SerializeField] private Vector3 direction;
        [SerializeField] private bool jumpKeyWasPressed;
        public float jumpForce;
        void Start()
        {
            var speed = direction * Speed * Time.deltaTime;
        }
        void Update()
        {   
            direction.x = Input.GetAxis("Horizontal");

            if (jumpKeyWasPressed)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
                    jumpKeyWasPressed = false;
                }
            }

        

        }
    
        private void FixedUpdate()
        {
            var speed = direction * Speed * Time.deltaTime;
        
            transform.Translate(speed);
            transform.Translate(Vector3.forward * Speed * Time.fixedDeltaTime);

            transform.Rotate(Vector3.up * Speed * Time.deltaTime, direction.y);

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Floor")
            {
                jumpKeyWasPressed = true;
            }

            if (collision.gameObject.tag == "Spike")
            {
                Debug.Log("столкновение");
            }
        }
    }
}
