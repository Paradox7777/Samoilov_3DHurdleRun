using UnityEngine;

namespace Runner
{
    public class FindTarget : MonoBehaviour
    {
        [SerializeField] private string targetTag;
        private Transform target;

        public Transform Target => target;
        public bool HasTarget => target != null;
        public string TargetTag => targetTag;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals(targetTag))
            {
                target = other.transform;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag.Equals(targetTag))
            {
                target = null;
            }
        }
    }
}