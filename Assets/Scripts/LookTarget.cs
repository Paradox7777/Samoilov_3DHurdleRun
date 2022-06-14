using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(FindTarget))]
    public class LookTarget : MonoBehaviour
    {
        private FindTarget findTarget;

        [SerializeField] private float rotationSpeed = 1f;

        private void Start()
        {
            findTarget = GetComponent<FindTarget>();
        }

        private void FixedUpdate()
        {
            if (!findTarget.HasTarget) { return; }

            var direction = findTarget.Target.position - transform.position;
            var step = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.fixedDeltaTime, 0f);

            transform.rotation = Quaternion.LookRotation(step);
        }
    }
}
